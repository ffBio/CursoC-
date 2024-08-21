using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Classes_Metodos;
using static CursoCSharp.Classes_Metodos.CalculadoraComum;

namespace CursoCSharp{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores - Fundamentos", Operadores.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atruibuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operador Unário - Fundamentos", OperadorUnario.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar },
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF/ELSE IF - Estruturas de Controle", EstruturaIfElseIF.Executar },
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura WHILE DO - Estruturas de Controle", EstruturaWhileDo.Executar },
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura FOR EACH - Estruturas de Controle", EstruturaForEach.Executar },
                {"BREAK - Estruturas de Controle", Break.Executar },
                {"CONTINUE - Estruturas de Controle", Continue.Executar },

                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar },
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar },
            });
            central.SelecionarEExecutar();
        }
    }
}