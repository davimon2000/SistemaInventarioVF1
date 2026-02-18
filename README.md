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
