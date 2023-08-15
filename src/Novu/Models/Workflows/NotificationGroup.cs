using Newtonsoft.Json;

namespace Novu.Models.Workflows;

public class WorkflowGroup
{
    [JsonProperty("_id")] public string Id { get; set; }

    [JsonProperty("_organizationId")] public string OrganizationId { get; set; }

    [JsonProperty("_environmentId")] public string EnvironmentId { get; set; }

    [JsonProperty("_parentId")] public string ParentId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}