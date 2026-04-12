Consulta Vista Estado general

WITH UltimaAsignacion AS (
    SELECT
        a.IdActivo,
        a.SedeId,
        a.EstadoDevolucion,
        ROW_NUMBER() OVER (
            PARTITION BY a.IdActivo
            ORDER BY a.Id DESC
        ) AS rn
    FROM Asignacion a
),

UltimoMtto AS (
    SELECT
        m.InventarioId,
        m.EstadoSalida,
        m.SedeSalidaID,
        ROW_NUMBER() OVER (
            PARTITION BY m.InventarioId
            ORDER BY m.Id DESC
        ) AS rn
    FROM Mantenimiento m
)

SELECT
    r.Id AS IdActivo,
    r.CodInterno,

    s.NombreSede AS Sede,

    CASE
        WHEN um.EstadoSalida = 'Baja' THEN 'Baja'

        WHEN um.EstadoSalida IS NULL 
             AND um.InventarioId IS NOT NULL 
        THEN 'En Mtto'

        WHEN um.EstadoSalida IS NOT NULL 
             AND um.EstadoSalida <> 'Baja'
        THEN um.EstadoSalida

        WHEN ua.EstadoDevolucion IS NULL 
             AND ua.IdActivo IS NOT NULL 
        THEN 'Asignado'

        WHEN ua.EstadoDevolucion IS NOT NULL 
        THEN ua.EstadoDevolucion

        ELSE r.EstadoRegistro
    END AS EstadoActual

FROM RegistroActivos r

LEFT JOIN UltimaAsignacion ua
    ON ua.IdActivo = r.Id AND ua.rn = 1

LEFT JOIN UltimoMtto um
    ON um.InventarioId = r.Id AND um.rn = 1

LEFT JOIN Sedes s
    ON s.Id = COALESCE(
        um.SedeSalidaID,
        ua.SedeId,
        r.SedeRegistroId
    );

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////VERSION 2 VISTA//////////////////////////////////////////////////


    CREATE VIEW vw_EstadoActualActivos_v2 AS

WITH UltimaAsignacion AS (
    SELECT
        a.IdActivo,
        a.SedeId,
        a.EstadoDevolucion,
        ROW_NUMBER() OVER (
            PARTITION BY a.IdActivo
            ORDER BY a.Id DESC
        ) AS rn
    FROM Asignacion a
),

UltimoMtto AS (
    SELECT
        m.InventarioId,
        m.EstadoSalida,
        m.SedeSalidaId,
        ROW_NUMBER() OVER (
            PARTITION BY m.InventarioId
            ORDER BY m.Id DESC
        ) AS rn
    FROM Mantenimiento m
),

UltimoEnvio AS (
    SELECT
        e.IdActivo,
        e.SedeDestinoId,
        e.FechaRecepcion,
        ROW_NUMBER() OVER (
            PARTITION BY e.IdActivo
            ORDER BY e.Id DESC
        ) AS rn
    FROM Envio e
)

SELECT
    r.Id AS IdActivo,
    r.CodInterno,

    -- SEDE ACTUAL
    CASE
        WHEN ue.FechaRecepcion IS NULL AND ue.IdActivo IS NOT NULL
            THEN r.SedeRegistroId  -- aún no llega
        WHEN ue.FechaRecepcion IS NOT NULL
            THEN ue.SedeDestinoId
        ELSE COALESCE(ua.SedeId, um.SedeSalidaId, r.SedeRegistroId)
    END AS SedeId,

    -- ESTADO ACTUAL
    CASE
        WHEN r.EstadoRegistro = 'Baja' OR um.EstadoSalida = 'Baja'
            THEN 'Baja'

        WHEN ue.FechaRecepcion IS NULL AND ue.IdActivo IS NOT NULL
            THEN 'En tránsito'

        WHEN um.EstadoSalida IS NOT NULL AND um.EstadoSalida <> 'Baja'
            THEN 'En Mtto'

        WHEN ua.EstadoDevolucion IS NULL AND ua.IdActivo IS NOT NULL
            THEN 'Asignado'

        WHEN ua.EstadoDevolucion IS NOT NULL
            THEN ua.EstadoDevolucion

        ELSE r.EstadoRegistro
    END AS EstadoActual

FROM RegistroActivos r

LEFT JOIN UltimaAsignacion ua
    ON ua.IdActivo = r.Id AND ua.rn = 1

LEFT JOIN UltimoMtto um
    ON um.InventarioId = r.Id AND um.rn = 1

LEFT JOIN UltimoEnvio ue
    ON ue.IdActivo = r.Id AND ue.rn = 1;


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////VERSION2 RESUMEN ACTIVO POR SEDE////////////////////////////////////////////////////////////////////////

CREATE VIEW vw_ResumenActivosPorSedeEstado AS
SELECT
    v.Sede,
    v.EstadoActual,
    COUNT(*) AS Cantidad
FROM vw_EstadoActualActivos_v2 v
GROUP BY
    v.Sede,
    v.EstadoActual;
    
