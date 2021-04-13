INSERT INTO [dbo].[GRAFICO] (
    [id], 
    [nombre], 
    [descripcion], 
    [titulo], 
    [subtitulo], 
    [tags], 
    [url], 
    [iso_pais], 
    [nivel_administrativo], 
    [descripcion_larga], 
    [fecha_publicacion], 
    [idioma], 
    [responsable], 
    [shopify], 
    [auxiliar], 
    [rango_edad], 
    [CATEGORIA_id], 
    [PARAMETRO_id], 
    [DETALLE_id], 
    [TERRITORIO_id], 
    [TEMPORALIDAD_id], 
    [TIPO_GRAFICO_id], 
    [FUENTE_id], 
    [unidad_medida], 
    [tamanio_muestra], 
    [caracteristica_especial], 
    [auxiliar_1], 
    [RESPONSABLE_id], 
    [UNIDAD_MEDIDA_id]) 
    VALUES (
        0, -- ID
        N'exportacion_primera_palta_dolares_chile_año 2020', -- Nombre
        'Cualquier descripción', -- Descripción (Cualquiera)
        N'Ejemplo Para Fines didacticos', -- Título
        'Subtítulo', -- Subtítulo
        'Tag', -- Tags
        N'palta.csv', -- URL
        'Sin ISO', -- ISO
        'Sin nivel', -- Nivel admin
        'Descripción que se despliega en la página del Statista.', -- Desc. larga
        '13-04-2021', -- Fecha publicación
        'Español', -- Idioma
        'Esta columna se tranformó en una referencia a una tabla externa.', -- Responsable
        'https://dataintelligence.store/', -- Shopify
        'Este es un comodín por si necesitamos un dato que no habíamos pensando.', -- Auxiliar
        'Sin rango', -- Rango edad
        100101001, -- Categoría ID
        1, -- Parámetro ID
        1, -- Detalle ID
        1, -- Teritorio ID
        1, -- Temporalidad ID
        1, -- Tipo gráfico
        0, -- Fuente ID
        'Esta columna se tranformó en una referencia a una tabla externa.', -- Unidad medida
        'Viene del Statista.', -- Unidad muestra
        'Viene del Statista.', -- Característica especial
        'Este es un comodín por si necesitamos un dato que no habíamos pensando.', -- Auxilar 1
        0, -- Responsable ID
        1 -- Unidad medida ID
         )