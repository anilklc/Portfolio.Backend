using Portfolio.Application.DTOs.Role;
using Portfolio.Application.Interfaces.Services;
using Portfolio.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Persistence.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<bool> CreateRole(string name)
        {
            IdentityResult result = await _roleManager.CreateAsync(new() { Name = name});
            return result.Succeeded;
        }

        public async Task<bool> DeleteRole(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            IdentityResult result = await _roleManager.DeleteAsync(role);
            return result.Succeeded;
        }

        public async Task<List<Role>> GetAllRole()
        {
            var roles =  _roleManager.Roles.ToList();
            return roles.Select(r => new Role()
            {
                Id = r.Id.ToString(),
                Name = r.Name,
            }).ToList();    
        }

        public async Task<Role> GetRoleById(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            return new()
            {
                Id = role.Id.ToString(),
                Name = role.Name,
            };
        }

        public async Task<bool> UpdateRole(string id,string name)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            role.Name = name;
            IdentityResult result = await _roleManager.UpdateAsync(role);
            return result.Succeeded;
        }
    }
}
