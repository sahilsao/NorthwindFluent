﻿using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Northwind.Client.Sessions
{
    public class CustomerSessions
    {
        public readonly ProtectedSessionStorage ProtectedSessionStorage;
        public CustomerSessions(ProtectedSessionStorage _ProtectedSessionStore)
        {
            ProtectedSessionStorage = _ProtectedSessionStore;
        }

        public async Task<String> GetCustomerID()
        {
            var val = await ProtectedSessionStorage.GetAsync<String>("CustomerID");
            return val.Value!;
        }

        public async Task<String> GetCompanyName()
        {
            var val = await ProtectedSessionStorage.GetAsync<String>("CompanyName");
            return val.Value!;
        }

        public async Task<String> GetContactName()
        {
            var val = await ProtectedSessionStorage.GetAsync<String>("ContactName");
            return val.Value!;
        }

        public async Task RemoveSessions()
        {
            await ProtectedSessionStorage.DeleteAsync("CustomerID");
            await ProtectedSessionStorage.DeleteAsync("CompanyName");
        }
    }
}
