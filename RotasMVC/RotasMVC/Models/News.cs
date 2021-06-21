using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RotasMVC.Models
{
    public class News
    {

        private int id;
        private string title;
        private string category;
        private DateTime date;
        private string content;

        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }


        [DisplayName("Titulo")]
        public string Title { get => title; set => title = value; }
        
        [DisplayName("Categoria")]
        public string Category { get => category; set => category = value; }
        
        [DisplayName("Data")]
        public DateTime Date { get => date; set => date = value; }
        
        [DisplayName("Noticia")]
        public string Content { get => content; set => content = value; }


        public IEnumerable<News> allNews()
        {
            // Instancia a Classe com Dados
            var infos = new Collection<News>
            {
                new News
                {
                    Id = 1,
                    Title = "Alunos repuldiam atitude LGBTfobica do Doscente",
                    Category = "Educação",
                    Content = "Alunos do 3° Ano do Ensino Medio repuldiaram a posição de um dos docentes que em" +
                    " um dos seus materiais de aula, desrespeitou a artista Pablo Vittar colocando-a em um exemplo" +
                    " como cargo de 'Testador de Supositorio'. Essa atitude foi apresentada pelos alunos ao docente," +
                    " entretanto o mesmo não se fez entender e desviou o assunto. Dessa forma, os estudantes" +
                    " recorream a outras medidas, uma vez que essa atitude não é adequada para um local de estudo," +
                    " mostrando uma falta de respeito e profissionalismo do funcionario.",
                    Date = new DateTime(2021, 06, 21)
                },
                new News
                {
                    Id = 2,
                    Title = "Constantes desentendimentos geram desinteresse em Alunos",
                    Category = "Educação",
                    Content = "Constantes discussões com os professores durante as aulas por motivos variados" +
                    " acabam gerando nos alunos um desinteresse nas disciplinas. Esse fato foi observado em uma" +
                    " sala de aula, onde alguns doscentes diante de um desentendimento com os alunos, não" +
                    " procuraram resolver a situação de forma concisa e focada na resolução do conflito, gerando" +
                    " um ambiente desconfortavel e não amigavel entre as duas partes.",
                    Date = new DateTime(2021,06,18)
                },
                new News
                {
                    Id = 3,
                    Title = "Alunos recorrem à coordenação da Escola após repetido conflitos com Doscentes",
                    Category = "Educação",
                    Content = "O evento ocorreu desde o inicio do ano de 2021 em uma escola publica do" +
                    " estado de São Paulo. O motivo central desses conflitos foi o não alinhamento do" +
                    " novo professor com a sua turma. Alguns dos conflitos foram causados pela falta da" +
                    " orientação formalizada do professor em suas tarefas, ataque a certos alunos, a não " +
                    "sensibilidade com alunos que não possuiam equipamentos que são suficientes para " +
                    " executar os exemplos de forma sincrona com a aula e outros.",
                    Date = new DateTime(2021, 04, 16)
                },
                new News
                {
                    Id = 4,
                    Title = "Araraquara - A cidade Exemplo",
                    Category = "Saúde",
                    Content = "Cidade do interior do Estado de São Paulo é exemplo nacional no metodo de" +
                    " combate à Pandemia do COVID-19, a qual foi a primeira a adotar medidas intensas," +
                    " como o Lockdown da cidade por cerca de 1 semana, barreiras sanitarias nas entradas " +
                    "da cidade e o toque de recolher. Todas essas medidas cairam o numero de mortes e as" +
                    " ocupações nas UTIs.",
                    Date = new DateTime(2021, 06, 19)
                },
                new News
                {
                    Id = 5,
                    Title = "Países julgam se Bolsonaro cometeu Crime contra a Humanidade",
                    Category = "Saúde",
                    Content = "O atual presidente da Republica Jair Bolsonaro que desde o inicio da" +
                    " Pandemia mostrou-se contra a COVID-19, manteve-se cetico e teve medidas que foram/são no" +
                    " minimo não corretas para o enfrentamento dessa situação. Com base nesses fatos, países" +
                    " como a Holanda avaliam se Bolsonaro com essas atitudes são uma ameaça aos seres humanos.",
                    Date = new DateTime(2021, 06, 21)
                },
            };

            return infos;
            
        }

    }
}