﻿using Abp.Application.Services;
using PTC.DOTIC.Tenants.Dashboard.Dto;

namespace PTC.DOTIC.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();

        GetDashboardDataOutput GetDashboardData(GetDashboardDataInput input);

        GetSalesSummaryOutput GetSalesSummary(GetSalesSummaryInput input);

        GetWorldMapOutput GetWorldMap(GetWorldMapInput input);

        GetGeneralStatsOutput GetGeneralStats(GetGeneralStatsInput input);
    }
}
