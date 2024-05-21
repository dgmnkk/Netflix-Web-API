using Microsoft.AspNetCore.Authorization;

namespace Netflix_Web_API.Requirements
{
    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public MinimumAgeRequirement(int minimumAge) =>
            MinimumAge = minimumAge;

        public int MinimumAge { get; }
    }
}
