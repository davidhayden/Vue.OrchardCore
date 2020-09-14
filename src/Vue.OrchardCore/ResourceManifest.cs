using OrchardCore.ResourceManagement;

namespace Vue.OrchardCore {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(IResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest
                .DefineScript("Vue")
                .SetUrl("/Vue.OrchardCore/Scripts/vue.min.js", "/Vue.OrchardCore/Scripts/vue.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/vue@2.6.12/dist/vue.min.js",
                    "https://cdn.jsdelivr.net/npm/vue@2.6.12/dist/vue.js")
                .SetCdnIntegrity("sha256-KSlsysqp7TXtFo/FHjb1T9b425x3hrvzjMWaJyKbpcI=",
                    "sha256-FZ8KwMj1F6qnNgA7bhPryVm19xKduH5OVr8u7I1tAtc=")
                .SetVersion("2.6.12");
        }
    }
}
