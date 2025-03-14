﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MindTrade.Models;
using Newtonsoft.Json;

namespace MindTrade.ViewComponents
{
    public class HeaderContent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return View();

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

            return View("LoggedIn");
        }
    }
}
