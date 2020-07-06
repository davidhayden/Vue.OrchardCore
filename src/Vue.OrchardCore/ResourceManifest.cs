using OrchardCore.ResourceManagement;

namespace Vue.OrchardCore {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(IResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest
                .DefineScript("Vue")
                .SetUrl("/Vue.OrchardCore/Scripts/vue.min.js", "/Vue.OrchardCore/Scripts/vue.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/vue@2.6.11/dist/vue.min.js",
                    "https://cdn.jsdelivr.net/npm/vue@2.6.11/dist/vue.js")
                .SetCdnIntegrity("sha384-OZmxTjkv7EQo5XDMPAmIkkvywVeXw59YyYh6zq8UKfkbor13jS+5p8qMTBSA1q+F",
                    "sha384-+jvb+jCJ37FkNjPyYLI3KJzQeD8pPFXUra3B/QJFqQ3txYrUPIP1eOfxK4h3cKZP")
                .SetVersion("2.6.11");
        }
    }
}