﻿using PTC.DOTIC.EntityFrameworkCore;

namespace PTC.DOTIC.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly DOTICDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(DOTICDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
