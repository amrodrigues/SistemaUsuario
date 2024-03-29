﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Contracts
{
    public interface IBaseBusiness<T> where T : class
    {

        void Cadastrar(T obj);

        void Atualizar(T obj);

        void Excluir(T obj);

        List<T> ConsultarTodos();

        T ConsultaPorId(int id);
    }
}
