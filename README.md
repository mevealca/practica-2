# practica-2
Implementación de SRP en el proyecto

Esta clase está violentando el principio debido a que dentro de una misma clase está cumpliendo con dos responsabilidades que son independientes una de otra ya que la clase persona solo debe establecer funciones que pertenezcan a la información de la persona y en este caso se está creando una función que envía correos que no corresponde a la clase persona lo que hace que rompa con el principio de una responsabilidad única 

solución
Por esto para la solución de nuestra app cree una clase independiente de EnviarCorreoElectronico y una interface con la funcionalidad de genéricos para que podamos extenderla en cualquier punto de nuestra app que necesitemos enviar un correo electrónico y pueda recibir una estructura de dato dinámica
