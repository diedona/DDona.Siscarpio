﻿using DDona.Siscarpio.Dto.Usuario;
using DDona.Siscarpio.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Siscarpio.Business
{
    public class UsuarioBusiness
    {
        public List<UsuarioListagemDTO> GetAllUsuarios()
        {
            try
            {
                using(SiscarpioContext db = new SiscarpioContext())
                {
                    List<UsuarioListagemDTO> Usuarios = db.Usuarios
                        .OrderBy(x => x.Nome)
                        .Select(x => new UsuarioListagemDTO
                        { 
                            Id = x.Id,
                            Nome = x.Nome,
                            Username = x.Username
                        })
                        .ToList();

                    return Usuarios;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<UsuarioListagemDTO> GetUsuarios(string Nome, string Username)
        {
            try
            {
                using (SiscarpioContext db = new SiscarpioContext())
                {
                    IQueryable<Usuario> Usuarios = db.Usuarios.AsQueryable();

                    if (!string.IsNullOrEmpty(Nome))
                    {
                        Usuarios = Usuarios.Where(x => x.Nome.Contains(Nome));
                    }

                    if (!string.IsNullOrEmpty(Username))
                    {
                        Usuarios = Usuarios.Where(x => x.Username.Contains(Username));
                    }

                    List<UsuarioListagemDTO> UsuariosDTO = Usuarios
                        .OrderBy(x => x.Nome)
                        .Select(x => new UsuarioListagemDTO()
                        {
                            Id = x.Id,
                            Nome = x.Nome,
                            Username = x.Username
                        }).ToList();

                    return UsuariosDTO;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool LogUser(string Username, string Password)
        {
            try
            {
                using(SiscarpioContext db = new SiscarpioContext())
                {
                    Usuario Usuario = db.Usuarios
                        .Where(x => x.Username.Equals(Username))
                        .Where(x => x.Password.Equals(Password))
                        .FirstOrDefault();

                    if(Usuario == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Salvar(string Username, string Nome, string Password)
        {
            Usuario Usuario = new Usuario()
            {
                Nome = Nome,
                Password = Password,
                Username = Username,
                Ativo = true,
                SenhaResetada = false
            };

            try
            {
                using(SiscarpioContext db = new SiscarpioContext())
                {
                    db.Usuarios.Add(Usuario);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
