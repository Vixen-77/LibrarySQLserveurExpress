SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
 WHERE TABLE_NAME = 'Patientss'

  ---------------------------------------------------------------------------------------


 SELECT 
    f.name AS ForeignKeyName,
    OBJECT_NAME(f.parent_object_id) AS TableName,
    COL_NAME(fc.parent_object_id, fc.parent_column_id) AS ColumnName,
    OBJECT_NAME(f.referenced_object_id) AS ReferencedTable,
    COL_NAME(fc.referenced_object_id, fc.referenced_column_id) AS ReferencedColumn
FROM 
    sys.foreign_keys AS f
JOIN 
    sys.foreign_key_columns AS fc 
    ON f.object_id = fc.constraint_object_id
WHERE 
    OBJECT_NAME(f.parent_object_id) = 'Nom de ma table ';


-------------------------------------------------------------------------------------------

SELECT 
    fk.name AS ForeignKey,
    tp.name AS ParentTable,
    ref.name AS ReferencedTable,
    c1.name AS ParentColumn,
    c2.name AS ReferencedColumn
FROM 
    sys.foreign_keys fk
INNER JOIN 
    sys.tables tp ON fk.parent_object_id = tp.object_id
INNER JOIN 
    sys.tables ref ON fk.referenced_object_id = ref.object_id
INNER JOIN 
    sys.foreign_key_columns fkc ON fkc.constraint_object_id = fk.object_id
INNER JOIN 
    sys.columns c1 ON fkc.parent_column_id = c1.column_id AND fkc.parent_object_id = c1.object_id
INNER JOIN 
    sys.columns c2 ON fkc.referenced_column_id = c2.column_id AND fkc.referenced_object_id = c2.object_id
WHERE 
    tp.name = 'NomDeTaTable';  -- Remplace 'NomDeTaTable' par le nom de ta table



SELECT 
    kc.name AS PrimaryKeyName,
    t.name AS TableName,
    c.name AS ColumnName
FROM 
    sys.key_constraints kc
INNER JOIN 
    sys.tables t ON kc.parent_object_id = t.object_id
INNER JOIN 
    sys.index_columns ic ON kc.unique_index_id = ic.index_id AND kc.parent_object_id = ic.object_id
INNER JOIN 
    sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
WHERE 
    kc.type = 'PK'  -- 'PK' = Primary Key
    AND t.name = 'NomDeTaTable';  -- Remplace par le nom de ta table
