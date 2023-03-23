using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "System",
    Author = "The Orchard Core Contrib Team",
    Version = "1.2.1",
    Category = "Utilities"
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.System",
    Name = "System",
    Description = "Provides an information about currently running application.",
    DefaultTenantOnly = true
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.System.Updates",
    Name = "System Updates",
    Description = "Displays the available system updates.",
    Dependencies = new[] { "OrchardCoreContrib.System" },
    DefaultTenantOnly = true
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.System.Maintenance",
    Name = "System Maintenance",
    Description = "Put your site in maintenance mode while you're doing upgrades.",
    Dependencies = new[] { "OrchardCore.Autoroute" }
)]