using System;

namespace TP_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipamentoS equip = new EquipamentoS();
            Locações locações = new Locações();
            int option;
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Cadastrar tipo de equipamento");
            Console.WriteLine("2. Consultar tipo de equipamento (com os respectivos itens cadastrados)");
            Console.WriteLine("3. Cadastrar equipamento (item em um determinado tipo)");
            Console.WriteLine("4. Registrar Contrato de Locação");
            Console.WriteLine("5. Consultar Contratos de Locação (com os respectivos itens contratados)");
            Console.WriteLine("6. Liberar de Contrato de Locação");
            Console.WriteLine("7. Consultar Contratos de Locação liberados (com os respectivos itens)");
            Console.WriteLine("8. Devolver equipamentos de Contrato de Locação liberado");
            Console.Write("Digite uma opção: ");
            option = int.Parse(Console.ReadLine());


            while (option != 0)
            {
                if (option == 1)
                {
                    Console.WriteLine("Digite o tipo de equipamento:");
                    string tipo = Console.ReadLine();
                    TipoEquip teqp = new TipoEquip();
                    teqp.Nome = tipo;
                    equip.Incluir(teqp);
                }
                if (option == 2)
                {
                    Console.WriteLine("Digite o tipo de equipamento:");
                    string tipo = Console.ReadLine();
                    TipoEquip teqp = new TipoEquip();
                    teqp.Nome = tipo;
                    foreach (TipoEquip tip in equip.Estoque)
                    {
                        if (tip.Equals(teqp))
                        {
                            Console.WriteLine("Tipo:" + teqp.Nome);
                            foreach (Equipamento eqp in tip.Itens)
                            {
                                Console.WriteLine("Id: " + eqp.Id + " Avariado: " + eqp.Avrd + " Disponivel: " + eqp.Lcd);
                            }
                        }
                    }
                }
                if (option == 3)
                {
                    Console.WriteLine("Digite o tipo de equipamento:");
                    string tipo = Console.ReadLine();
                    TipoEquip teqp = new TipoEquip();
                    teqp.Nome = tipo;
                    foreach (TipoEquip tip in equip.Estoque)
                    {
                        if (tip.Equals(teqp))
                        {
                            Console.WriteLine("Quantos equipamentos você quer cadastrar: ");
                            int qtd = int.Parse(Console.ReadLine());
                            for (int i = 0; i < qtd; i++)
                            {
                                Equipamento eqp = new Equipamento();
                                eqp.Lcd = false;
                                eqp.Avrd = false;
                                tip.Incluir(eqp);
                            }
                        }
                    }
                }
                if (option == 4)
                {

                    Locação locação = new Locação();
                    Console.WriteLine("Digite a data de saida: ");
                    string data_saida = Console.ReadLine();
                    Console.WriteLine("Digite a data de retorno: ");
                    string data_retorno = Console.ReadLine();
                    locação.Data_saida = DateTime.Parse(data_saida);
                    locação.Data_retorno = DateTime.Parse(data_retorno);
                    string optionC = "";
                    while (optionC != "0")
                    {
                        Console.WriteLine("Digite o tipo do equipamento: ");
                        string tipo = Console.ReadLine();
                        TipoEquip teqp = new TipoEquip();
                        teqp.Nome = tipo;
                        Console.WriteLine("Quantos equipamentos você quer cadastrar: ");
                        int qtd = int.Parse(Console.ReadLine());
                        for (int i = 0; i < qtd; i++)
                        {
                            Equipamento eqp = new Equipamento();
                            eqp.Lcd = false;
                            eqp.Avrd = false;
                            teqp.Incluir(eqp);
                            foreach (TipoEquip tequipamento in equip.Estoque)
                            {
                                if (equip.Estoque.Equals(teqp))
                                {
                                    foreach (Equipamento equipamento in tequipamento.Itens)
                                    {
                                        if (equipamento.Equals(eqp))
                                        {
                                            equipamento.Lcd = true;
                                        }
                                    }
                                }
                            }

                        }
                        locação.Incluir(teqp);

                        Console.WriteLine("Digite 0 se não quiser cadastrar outro equipamento: ");
                        optionC = Console.ReadLine();
                    }

                    locações.Incluir(locação);

                }
                if (option == 5)
                {
                    Console.WriteLine("Digite o código do Contrato:");
                    int lid = int.Parse(Console.ReadLine());
                    Locação l = new Locação();
                    l.Id = lid;
                    foreach (Locação L in locações.Contratos)
                    {
                        if (L.Equals(l))
                        {
                            l = L;
                            foreach (TipoEquip teqp in l.Itens)
                            {
                                Console.WriteLine("Tipo:" + teqp.Nome);
                                foreach (Equipamento eqp in teqp.Itens)
                                {
                                    Console.WriteLine("Id:" + eqp.Id + " Avariado:" + eqp.Avrd + " Alocado:" + eqp.Lcd);

                                }
                            }
                        }
                    }
                }
                if (option == 6)
                {

                    Console.WriteLine("Digite o codigo do Contrato: ");
                    int lid = int.Parse(Console.ReadLine());
                    Locação l = new Locação();
                    l.Id = lid;
                    foreach (Locação L in locações.Contratos)
                    {
                        if (L.Equals(l))
                        {
                            L.Liberado = true;
                        }
                    }
                }
                if (option == 7)
                {
                    foreach (Locação L in locações.Contratos)
                    {
                        if (L.Liberado == true)
                        {
                            Console.WriteLine("Id:" + L.Id + " Data de Saida:" + L.Data_saida + " Data de Retorno:" + L.Data_retorno);
                        }
                        foreach (TipoEquip teqp in L.Itens)
                        {
                            Console.WriteLine("Tipo:" + teqp.Nome);
                            foreach (Equipamento eqp in teqp.Itens)
                            {
                                Console.WriteLine("Id:" + eqp.Id + " Avariado:" + eqp.Avrd + " Disponivel:" + eqp.Lcd);
                            }
                        }
                    }
                }
                if (option == 8)
                {
                    Console.WriteLine("Digite o codigo do Contrato:");
                    int lid = int.Parse(Console.ReadLine());
                    Locação l = new Locação();
                    l.Id = lid;
                    foreach (Locação L in locações.Contratos)
                    {
                        if (L.Equals(l))
                        {
                            l = L;
                            foreach (TipoEquip teqp in l.Itens)
                            {
                                foreach (TipoEquip tequipamentos in equip.Estoque)
                                {
                                    if (teqp == tequipamentos)
                                    {
                                        foreach (Equipamento eqp in tequipamentos.Itens)
                                        {
                                            foreach (Equipamento eqp1 in tequipamentos.Itens)
                                            {
                                                if (eqp == eqp1)
                                                {
                                                    eqp.Lcd = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar tipo de equipamento");
                Console.WriteLine("2. Consultar tipo de equipamento (com os respectivos itens cadastrados)");
                Console.WriteLine("3. Cadastrar equipamento (item em um determinado tipo)");
                Console.WriteLine("4. Registrar Contrato de Locação");
                Console.WriteLine("5. Consultar Contratos de Locação (com os respectivos itens contratados)");
                Console.WriteLine("6. Liberar de Contrato de Locação");
                Console.WriteLine("7. Consultar Contratos de Locação liberados (com os respectivos itens)");
                Console.WriteLine("8. Devolver equipamentos de Contrato de Locação liberado");
                Console.WriteLine("Digite uma opção: ");
                option = int.Parse(Console.ReadLine());
            }

        }

    }
    
}
