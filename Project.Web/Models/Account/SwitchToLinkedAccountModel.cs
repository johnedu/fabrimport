﻿using Abp;

namespace Project.Web.Models.Account
{
    public class SwitchToLinkedAccountModel
    {
        public int? TargetTenantId { get; set; }

        public long TargetUserId { get; set; }

        public UserIdentifier ToUserIdentifier()
        {
            return new UserIdentifier(TargetTenantId, TargetUserId);
        }
    }
}