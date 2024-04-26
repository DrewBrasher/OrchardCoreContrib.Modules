using OrchardCore.Modules.Manifest;
using ManifestConstants = OrchardCoreContrib.Modules.Manifest.ManifestConstants;

[assembly: Module(
    Name = "Google Maps",
    Author = ManifestConstants.Author,
    Website = ManifestConstants.Website,
    Version = "1.3.1",
    Description = "Displays Google maps.",
    Dependencies = new[] { "OrchardCore.Contents" },
    Category = "Content Management"
)]
