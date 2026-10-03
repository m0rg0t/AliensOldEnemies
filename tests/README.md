# Portable regression checks

These tests execute the selected production source using synthetic inputs and explicit platform stubs. They do not start the app, access a sensor, location, network, audio device or real game service.

Run `dotnet run --project tests/Portable.Tests/Portable.Tests.csproj --configuration Release` with .NET SDK 10.0.401. The harness links the actual application files and compiles in C# 5 mode, with no NuGet package sources. The historic Phone project and its dependencies remain unchanged.

Coverage: crew/item selection is idempotent at the existing four/five limits; capacity rejection, deselection and newly freed slots; empty, single and multiple ability summaries. The fake status object supplies synthetic selected counts; Silverlight binding/rendering and the complete game remain unverified.

Full native validation still requires the matching historical Windows Phone SDK and original third-party assemblies. This harness is not a platform migration or a native build certification.
