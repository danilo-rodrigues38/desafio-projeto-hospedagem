using desafio_projeto_hospedagem.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo ( "pt-BR" );


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "Hospedado 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "Hospedado 2");

hospedes.Add ( p1 );
hospedes.Add ( p2 );


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);


Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite ( suite );
reserva.CadastrarHospedes ( hospedes );


Console.WriteLine ( $"Hóspedes: {reserva.ObterQuantidadeHospedes ( )}" );
Console.WriteLine ( $"Valor diária: {reserva.CalcularValorDiaria ( ).ToString ( "C", CultureInfo.CreateSpecificCulture ( "pt-BR" ) )}" );