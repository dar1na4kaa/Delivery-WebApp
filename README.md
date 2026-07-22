# Delivery-WebApp
# Delivery Service

Web-приложение для управления заказами доставки.

Проект реализован на ASP.NET Core с использованием Clean Architecture.

## Используемые технологии

- ASP.NET Core MVC (.NET 9)
- Entity Framework Core 9
- PostgreSQL
- Razor Views
- Bootstrap
- Dependency Injection


## Архитектура проекта

Проект разделён на слои:

### Domain
Содержит основные бизнес-сущности.

### Application
Содержит бизнес-логику:
- DTO
- интерфейсы
- сервисы

### Infrastructure
Отвечает за работу с базой данных:
- Entity Framework Core
- PostgreSQL
- Repository

### Presentation
MVC слой:
- Controllers
- Razor Views


### Core
Точка запуска приложения.


## Требования

Перед запуском необходимо установить:

- .NET 9 SDK
- PostgreSQL


## Настройка базы данных

В файле Core/appsettings.json
указать строку подключения:
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=DeliveryOrders;Username=ВАШ_USERNAME;Password=ВАШ_ПАРОЛЬ"
  }
}

## Запуск проекта
Клонировать репозиторий:
- git clone <repository-url>
Перейти в папку проекта:
- cd Delivery
Восстановить зависимости:
- dotnet restore
Запустить приложение:
- dotnet run --project Core
