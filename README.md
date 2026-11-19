# CineCatalog

Proyecto grupal de Tecnología Web I. Backend **.NET 10 Web API con controladores**, **Docker Compose**, **PostgreSQL 17** y Entity Framework Core.

## Inicio rápido en Ubuntu / WSL 2

Requisitos: Docker Engine y plugin Docker Compose; .NET SDK 10 para trabajar fuera del contenedor (Docker compila por sí mismo).

```bash
cp .env.example .env
nano .env                # Cambiar POSTGRES_PASSWORD por una contraseña fuerte (sin ; en esta versión)
docker compose config   # Verificar sintaxis sin compartir la salida (puede mostrar secretos)
docker compose up --build -d
docker compose ps
curl http://localhost:8080/api/estado
```

Respuesta esperada (valores de fecha variables):

```json
{"api":"funcionando","postgresql":"conectado","fechaUtc":"..."}
```

Comprueba PostgreSQL desde el contenedor:

```bash
docker compose exec db sh -c 'psql -U "$POSTGRES_USER" -d "$POSTGRES_DB" -c "SELECT current_database();"'
```

Para revisar errores: `docker compose logs -f api` o `docker compose logs -f db`.

Para detener sin borrar datos: `docker compose down`.

**No ejecutar `docker compose down -v`** salvo que se quiera borrar el volumen de datos PostgreSQL.

La base de datos no se expone directamente al equipo anfitrión, para evitar choques con un PostgreSQL instalado en WSL. El puerto de la API solo está publicado en localhost:8080.

## Ramas

- `main`: versión estable.
- `develop`: integración de los módulos.
- `feature/catalogo`: infraestructura y CRUD de películas, series y géneros.
- `feature/auth-google`: usuarios, JWT, sesiones y Google.
- `feature/auth-tiktok`: TikTok e integración de prueba del login.

Cada integrante crea su rama **desde `develop`**, hace push a su rama y abre un Pull Request **hacia `develop`**. No se hace push directo a `main`. Revisar los cambios antes de integrar, especialmente `AppDbContext` y migraciones.

## Estado inicial

- [x] API con controladores
- [x] Dockerfile .NET 10 (multi-stage)
- [x] Docker Compose con API y PostgreSQL
- [x] DbContext de base y endpoint para verificar conexión
- [ ] Modelos, migraciones y CRUD de catálogo
- [ ] JWT y refresh token
- [ ] Login con Google
- [ ] Login con TikTok
- [ ] Frontend de demostración

**No existen tablas de negocio aún**. Las agregaremos con migraciones coordinadas cuando estén definidos los modelos.

## Seguridad

No guardar contraseñas, claves de Google/TikTok ni tokens reales en el repositorio. Usar `.env` local y secretos de entorno adecuados. Cuando se haga despliegue público, configurar HTTPS, secretos fuera del código, perfiles de producción, CORS controlado y protección de rutas.

## Estructura

```text
CineCatalog/
├── CineCatalog.slnx
├── CineCatalog.API/
│   ├── Controllers/EstadoController.cs
│   ├── Data/AppDbContext.cs
│   ├── Program.cs
│   └── CineCatalog.API.csproj
├── Dockerfile
├── compose.yaml
├── .env.example
├── .gitignore
└── README.md
```
