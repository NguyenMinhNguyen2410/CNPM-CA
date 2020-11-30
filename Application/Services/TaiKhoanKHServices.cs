using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services
{
    
    public class TaiKhoanKHServices : ITaiKhoanKHServices
    {
        //public readonly HttpContext _httpContext;
        public readonly ITaiKhoanKHRepository _taiKhoanRepository;
        /*public TaiKhoanKHServices(IHttpContextAccessor httpContextAccessor,ITaiKhoanKHRepository taiKhoanKHRepository)
        {
            _taiKhoanRepository = taiKhoanKHRepository;
            //_httpContext = httpContextAccessor.HttpContext;
        }*/
        public TaiKhoanKHServices(ITaiKhoanKHRepository taiKhoanKHRepository)
        {
            _taiKhoanRepository = taiKhoanKHRepository;
            //_httpContext = httpContextAccessor.HttpContext;
        }

        public bool login(string taiKhoan , string matKhau)
        {
            var list = _taiKhoanRepository.getAll();
            //var listdoi = list.MappingDTO();
            var flag = false;
            foreach (var item in list)
            {
                if (taiKhoan.Equals(item.TaiKhoan))
                {
                    if (matKhau.Equals(item.MatKhau))
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, item.TaiKhoan));

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        //_httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).Wait();
                        flag = true;
                    }
                }
            }
            return flag;
        }
    }
}
