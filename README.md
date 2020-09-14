# Vue.OrchardCore

Vue.OrchardCore is an Orchard Core CMS Module that provides [Vue.js](https://github.com/vuejs) as a resource.

## Status
[![Build status](https://ci.appveyor.com/api/projects/status/hdtu0a85wdv4ldhn?svg=true)](https://ci.appveyor.com/project/davidhayden/vue-orchardcore) [![Status](https://img.shields.io/myget/davidhayden-ci/v/Vue.OrchardCore.svg)](https://www.myget.org/feed/davidhayden-ci/package/nuget/Vue.OrchardCore)

## Resources

| Name | Type | Versions | Dependencies |
| ---- | ---- | -------- | ------------ |
| Vue  | Script | 2.6.12 | - |

## Usages

Resources are commonly included in your templates using tag helpers.

Examples using Liquid:

```liquid
{% script name:"Vue", at:"Foot" %}

{% script name:"Vue", use_cdn:"true" %}

{% script name:"Vue", version:"2.6.12" %}
```

Consult the Orchard Core documentation for information on [resources](https://orchardcore.readthedocs.io/en/latest/OrchardCore.Modules/OrchardCore.Resources/README/).

## Credits
Created and maintained by David Hayden.
