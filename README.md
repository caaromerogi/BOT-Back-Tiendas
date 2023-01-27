# Introducción
Proyecto de practica de la plantilla basada en arquitectura limpia de Sistecrédito.

# Importante
1.  Cambiar la cadena de conexion de mongo antes de ejecutar.
2.  La colección de TiposTienda, como no tiene método para insertar se debe crear previamente, 
la primer tienda que creen usando el endpoint del Api va quedar con un Tipo por defecto que no existe (0 y null). luego de esto como ya existe la base de datos, 
creen manualmente la colección de Tipos tienda con los documentos que están a continuación para que las tiendas les creen con el tipo correcto.

```javascript
{
    "_id" : NumberInt(1),
    "nombre" : "Físico"
}
{
    "_id" : NumberInt(2),
    "nombre" : "Virtual"
}
```

Otra opción es crear la colección vacía y luego correr este Query. 

```javascript
db.getCollection("TiposTienda").insertMany([
{
    "_id" : NumberInt(1),
    "nombre" : "Físico"
},
{
    "_id" : NumberInt(2),
    "nombre" : "Virtual"
}])
```

Y luego este para validar que se crearon los dos registros

```javascript
db.getCollection("TiposTienda").find({})
```

Para probar la api:

[![Run in Postman](https://run.pstmn.io/button.svg)](https://documenter.getpostman.com/view/1313729/2s8ZDeTJQw#c727fd8d-f252-43c3-ae74-c5af8aeb62bc)

Les recomiendo usar como IDE para mongo Studio 3t, la version gratuita. Lo poden descargar aqui:

[![Studio 3t](https://signin.studio3t.com/ALL/20220324100420/assets/images/image.jpg)](https://studio3t.com/download/)

<pre>








</pre>

🄾🄹🄾 🄲🄾🄽 🄴🄻 🄲🄰🄿🄴🅃🄴 :)