﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VendedorController
    {
        public void SalvarVendedor(Vendedor vendedor)
        {
            try
            {
                Vendedor.Salvar(vendedor);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void AlterarVendedor(int id, String NovoNome, float NovaComissao, String NovoCPF, int idCargo)
        {
            try
            {
                Vendedor vendedor = GetById(id);

                if (vendedor != null)
                {
                    Vendedor.Atualizar(id, NovoNome, NovaComissao, NovoCPF, idCargo);
                }
                else
                {
                    throw new Exception("Cliente nao encontrado");
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void ExcluirVendedor(int id)
        {
            try
            {
                Vendedor vend = Vendedor.GetById(id);
                if (vend != null)
                    Vendedor.Remove(id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public IList<Vendedor> ListarVendedor()
        {
            IList<Vendedor> ListarVendedor;
            try
            {
                ListarVendedor = Vendedor.ListarVendedors();
                Vendedor.ListarVendedors();
            }
            catch (Exception e)
            {
                throw (e);
            }
            return ListarVendedor;
        }

        public Vendedor GetById(int id)
        {

            Vendedor obj = new Vendedor();
            try
            {

                obj = Vendedor.GetById(id);
            }
            catch (Exception e)
            {
                throw (e);
            }
            return obj;
        }
    }
}

