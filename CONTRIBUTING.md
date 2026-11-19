# Reglas de colaboración del proyecto

Estas reglas ayudan al equipo a colaborar y a integrar cambios de forma segura en CineCatalog. Aplican a todos los integrantes del proyecto.

## 1. Organización de ramas

- `main` contendrá únicamente versiones estables del proyecto.
- `develop` será la rama donde se integrará el trabajo del equipo.
- Cada integrante trabajará en una rama propia con el formato `feature/nombre-funcionalidad`.
- No se permite trabajar directamente sobre `main` ni `develop`.
- Las ramas de trabajo deben crearse desde `develop`, y los Pull Requests deben dirigirse a `develop`.

## 2. Reglas para los integrantes

- Cada integrante es responsable de las tareas que tenga asignadas.
- No modificar archivos a cargo de otro compañero sin avisarle.
- Comunicar al equipo cualquier cambio importante.
- Mantener el código organizado y comprensible.
- No eliminar funcionalidades desarrolladas por otros integrantes sin autorización.

## 3. Commits

- Realizar commits después de completar cambios funcionales.
- Escribir mensajes claros que expliquen lo realizado.
- Evitar mensajes ambiguos como `cambios` o `arreglo`.
- No subir archivos innecesarios, como `bin/`, `obj/` o archivos temporales.

## 4. Integración de cambios

- Actualizar la rama personal con los últimos cambios de `develop` antes de integrar el trabajo.
- Verificar que el proyecto compile correctamente.
- Crear un Pull Request hacia `develop`.
- Al menos un compañero debe revisar los cambios antes de aprobar la integración.
- No integrar código que presente errores conocidos.

## 5. Base de datos

- Utilizar PostgreSQL como gestor de base de datos.
- Coordinar cualquier modificación de tablas o relaciones.
- Crear migraciones de Entity Framework Core con nombres descriptivos.
- No eliminar tablas ni modificar migraciones compartidas sin consultar al equipo.
- Verificar que las migraciones funcionen antes de subirlas.

## 6. Código y API

- Seguir los estándares de desarrollo de C# y .NET.
- Mantener los controladores, modelos y servicios organizados.
- Evitar duplicar métodos o funcionalidades.
- Verificar los endpoints antes de integrar cambios.
- Utilizar nombres descriptivos para clases, métodos y variables.

## 7. Docker y configuración

- Mantener actualizados `Dockerfile` y `compose.yaml` cuando corresponda.
- Verificar que los servicios puedan ejecutarse correctamente.
- No subir contraseñas, tokens, claves privadas ni archivos `.env` con credenciales.
- Documentar los cambios necesarios para ejecutar el proyecto.

## 8. Resolución de conflictos

- Avisar al equipo cuando aparezcan conflictos de Git.
- Revisar cuidadosamente los archivos afectados.
- No eliminar código de otros compañeros para resolver conflictos.
- Comprobar que la aplicación continúe funcionando después de resolverlos.

## 9. Responsabilidad del equipo

- Cada integrante debe completar y probar su parte.
- Avisar al equipo cuando una tarea esté terminada.
- Respetar el trabajo de los demás.
- Mantener la comunicación antes de realizar cambios que afecten a todo el proyecto.
