# StarterKit - .NET Modular Monolith

A modern, production-ready starter kit for building modular monolith applications with .NET. This project provides a solid foundation for building scalable and maintainable .NET applications following clean architecture principles and modern development practices.

## 🚀 Features

- **Modular Architecture**: Built with a modular monolith approach for better separation of concerns
- **Clean Architecture**: Follows clean architecture principles with clear separation of layers
- **ASP.NET Core Web API**: RESTful API endpoints with Swagger/OpenAPI support
- **Building Blocks**: Reusable components and abstractions for common functionality
- **Aspire Integration**: Ready for cloud-native development with .NET Aspire
- **Cross-Cutting Concerns**: Built-in support for logging, validation, and exception handling

## 🏗️ Project Structure

```
StarterKit/
├── src/
│   ├── Apps/                  # Application entry points
│   │   └── Web.Api/           # Web API project (API Gateway)
│   │
│   ├── Aspire/                # Aspire components and services
│   │   └── ...
│   │
│   └── BuildingBlocks/        # Reusable building blocks
│       ├── Application/       # Application layer components
│       └── SharedKernel/      # Domain models and shared abstractions
│
├── .editorconfig             # Code style settings
├── Directory.Build.props     # Common build properties
├── Directory.Packages.props  # Central package management
└── StarterKit.sln           # Solution file
```

## 🛠️ Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with ASP.NET and web development workload
- [.NET Aspire workload](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/install) (for Aspire features)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (for containerization)

## 🚀 Getting Started

### Clone the repository

```bash
git clone https://github.com/nguyenhnhatquang/dotnet-starter-kit.git
cd dotnet-starter-kit/StarterKit
```

### Run with Aspire

#### Using Visual Studio 2022:

1. Open the solution in Visual Studio 2022
2. Set `Aspire.AppHost` as the startup project
3. Run the application (F5 or Ctrl+F5)

#### Using .NET CLI:

```bash
dotnet run --project src/Aspire/Aspire.AppHost
```

This will start the Aspire dashboard along with all the configured services.

### Access the Dashboard

After the application starts, the Aspire dashboard will open automatically in your default browser at:

- Dashboard: `http://localhost:18888`

From the dashboard, you can:

- View all running services
- Access service endpoints
- View logs and metrics
- Access service-specific UIs (like Swagger for APIs)

### Access Individual Services

Once running, you can access individual services through their respective endpoints as configured in the Aspire host. Common endpoints include:

- API Swagger: `http://localhost:5xxx/swagger` (port may vary, check the dashboard)

## 🏗️ Adding New Modules

1. Create a new module in the `src/Modules` directory
2. Implement the module following the same structure as existing modules
3. Register your module in the Web API project's `Program.cs`

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [.NET](https://dotnet.microsoft.com/)
- [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [Modular Monolith](https://www.kamilgrzybek.com/blog/architecture/modular-monolith-primer/)
- [.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/)
