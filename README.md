# Vue.OrchardCore

Vue.OrchardCore is an Orchard Core CMS Module that provides [Vue.js](https://github.com/vuejs) as a resource.

## Resources

| Name | Type | Versions | Dependencies |
| ---- | ---- | -------- | ------------ |
| Vue  | Script | 2.5.17 | - |

## Usages

Resources are commonly included in your templates using tag helpers.

Examples using Liquid:

```liquid
{% script name:"Vue", at:"Foot" %}

{% script name:"Vue", use_cdn:"true" %}

{% script name:"Vue", version:"2.5.17" %}
```

Consult the Orchard Core documentation for information on [resources](https://orchardcore.readthedocs.io/en/latest/OrchardCore.Modules/OrchardCore.Resources/README/).

## Credits
Created and maintained by David Hayden.