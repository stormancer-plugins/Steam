using Stormancer.Plugins;

namespace Stormancer.Server.Steam
{
    class SteamPlugin : IHostPlugin
    {
        public void Build(HostPluginBuildContext ctx)
        {
            ctx.HostDependenciesRegistration += RegisterDependencies;
        }

        private void RegisterDependencies(IDependencyBuilder builder)
        {
           
            builder.Register<SteamService>().As<ISteamService>().InstancePerScene();
        }
    }
}
