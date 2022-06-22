﻿using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Identity;

namespace Omikron.IdentityService.Infrastructure.Data.Model
{
    [MultiTenant]
    public class UserRole: IdentityUserRole<int>
    {
    }
}
