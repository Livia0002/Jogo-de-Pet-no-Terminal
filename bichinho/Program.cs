using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace bichinho
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string entrada = "";
            string nome = "";
            string nomeDono = "";
            float alimentacao = 100;
            float limpeza = 100;
            float felicidade = 100;

            int caracteristica = 0;
            Random rand = new Random();

            string[] frases = new string[10];
            frases[0] = "Eu gosto de estrelas! Quando você olha para o céu estrelado à noite, você está literalmente olhando para o passado, vendo luzes de estrelas que talvez já tenham morrido.";
            frases[1] = "As vezes eu penso... Mais ou menos mais de 100 bilhões de seres humanos já morreram, então estamos caminhando sobre a história de todos eles todos os dias.";
            frases[2] = "Eu amo estrelas... Sabia que quase todos os átomos que compõem o seu corpo foram forjados no coração de uma estrela que explodiu bilhões de anos atrás?";
            frases[3] = "As vezes eu morro de rir quando lembro que uma pequena cidade no Alasca chamada Talkeetna teve um gato chamado Stubbs como prefeito honorário por 20 anos. HAHAHAHA";
            frases[4] = "Um dia, alguém vai pronunciar o seu nome pela última vez na Terra, e você se tornará uma parte silenciosa e anônima da história humana. HAHAHA, o que foi?";
            frases[5] = "Se você colocar dois espelhos perfeitamente virados um para o outro, as luzes vão rebater infinitamente, mas você nunca verá o reflexo do infinito porque a sua própria cabeça fica no caminho. Cabeção.";
            frases[6] = "Sabe... na década de 1960, a CIA gastou milhões de dólares para treinar cirurgicamente um gato com microfones e antenas para espionar a embaixada soviética; no primeiro dia de teste na rua, o gato foi atropelado por um táxi. Pobre felino.";
            frases[7] = "Durante a Segunda Guerra Mundial, o governo britânico tentou construir um porta-aviões gigante feito inteiramente de uma mistura de gelo e serragem de madeira para economizar metal, mas o navio derreteu antes de ficar pronto.";
            frases[8] = "Tanques de guerra infláveis feitos de borracha foram usados pelos americanos para enganar os nazistas, mas a farsa quase foi descoberta quando dois soldados inimigos viram um único soldado carregando e levantando um tanque inteiro com as mãos.";
            frases[9] = "Um drone submarino ultra-secreto da Marinha americana, projetado para parecer um peixe real, foi capturado e frito por pescadores locais que acharam que tinham pescado o jantar.";

            Console.WriteLine("Meu Bichinho Virtual");

            if (args.Length > 0)
            {
                nome = args[0];
            } else
            {
                Console.WriteLine("Dê um nome para o seu Bichinho: ");
                nome = Console.ReadLine();
            }
            Console.WriteLine("Olá, qual é o seu nome?");
            nomeDono = Console.ReadLine();
            Console.WriteLine("Legal, estava com muita saudade de você, {0}!",nomeDono);

            if(File.Exists(C:\\)){

            entrada = "sim";
            while(entrada.ToLower() != "nada" && alimentacao>0 && limpeza>0 && felicidade>0)
            {
                caracteristica = rand.Next(3);
                switch (caracteristica)
                {
                    case 0: alimentacao -= rand.Next(20); break;
                    case 1: limpeza -= rand.Next(20); break;
                    case 2: felicidade -= rand.Next(20); break;
                }    
                Console.Clear();

                Console.WriteLine("Oi, {0}!!!!", nomeDono);
                if (alimentacao > 20 && alimentacao < 50)
                {
                    Console.WriteLine("Eu estou faminto!\n Nada melhor que uma comidinha....");
                }
                if (limpeza > 20 && limpeza < 50)
                {
                    Console.WriteLine("Eu estou uma sujeira!\n Nada melhor que um banhinho....");
                }
                if (felicidade > 20 && felicidade < 50)
                {
                    Console.WriteLine("Eu fiquei em casa o dia todo!\n Nada melhor que brincar....");
                }
                Thread.Sleep(3000);
                Console.Clear() ;

                Console.WriteLine(frases[rand.Next(frases.Length)]);
                Console.WriteLine("O que vamos fazer agora?");
                Console.WriteLine("Brincar/Comer/Banho/Nada: "); 
                entrada= Console.ReadLine().ToLower();
                switch (entrada)
                {
                    case "comer": alimentacao += rand.Next(25); break;
                    case "banho": limpeza += rand.Next(25); break;
                    case "brincar": felicidade += rand.Next(25); break;
                }
                if(alimentacao > 100) alimentacao = 100;
                if (limpeza > 100) limpeza = 100;
                if (felicidade > 100) felicidade = 100;
            }
            Console.Clear();

            if(alimentacao <= 0 || limpeza <= 0 || felicidade <= 0)
            {
                Console.WriteLine("Oh, meu Deus! Seu bichinho morreu!");
                Console.WriteLine("█   █  ███  ████  █████ █████   \r\n██ ██░█ ░░█ █░░░█  ░█░░░█░░░░░  \r\n█░█ █░█░ ░█░████░░  █░░░████░░░ \r\n█░░░█░█░░ █░█░░█░ ░ █░░ █░░░░   \r\n█░░ █░░███ ░█░░░█░  █░░ █████░  \r\n ░░  ░░ ░░░ ░░░  ░   ░░  ░░░░░  \r\n  ░   ░  ░░░  ░   ░   ░   ░░░░░ ");
            }
            else
            {
                Console.WriteLine("Adorei brincar com você! Volte logo!");
            }
            Console.ReadKey();
        }
    }
}
