using OrchardCore.ResourceManagement;

namespace Vue.OrchardCore {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(IResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest
                .DefineScript("Vue")
                .SetUrl("/Vue.OrchardCore/Scripts/vue.min.js", "/Vue.OrchardCore/Scripts/vue.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/vue@2.5.17/dist/vue.min.js",
                    "https://cdn.jsdelivr.net/npm/vue@2.5.17/dist/vue.js")
                .SetVersion("2.5.17");
        }
    }
}