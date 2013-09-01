using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;



namespace ProyectoFrases
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

           //  base de datos 
            using (BaseDeDatosFrasesDataContext dataContext = new BaseDeDatosFrasesDataContext("Data source='isostore:/AmorDB.sdf'"))
            {

                if (!dataContext.DatabaseExists())
                {
                    dataContext.CreateDatabase();

                    List<Amor> amorObj = new List<Amor>()
                    {

                        // Frase 1
                        new Amor()
                        {
                            Id = 1 , Frase = "Tardé una hora en conocerte y solo un día en enamorarme.Pero me llevará toda una vida lograr olvidarte."

                        },

                        // Frase 2
                        new Amor()
                        {
                            Id = 2 , Frase = "Si yo fuese el mar, y tu una roca, haría subir la marea, para besar tu boca."

                        },

                        // Frase 3
                        new Amor()
                        {
                            Id = 3 , Frase = "El amor es como los fantasmas, todo el mundo habla de él pero pocos lo han visto."

                        },

                        // Frase 4
                        new Amor()
                        {
                            Id = 4 , Frase = "¿Qué puedes hacer si la persona que te hace llorar tanto es la única capaz de consolarte?"

                        },

                        // Frase 5
                        new Amor()
                        {
                            Id = 5 , Frase = "Uno está enamorado cuando se da cuenta de que otra persona es única."

                         },

                        // Frase 6
                         new Amor()
                         {
                             Id = 6 , Frase = "En un beso, sabrás todo lo que he callado." 

                         },

                         // Frase 7
                         new Amor()
                         {
                             Id = 7 , Frase = "No cambiaría un minuto de ayer contigo por cien años de vida sin ti."

                         },

                         // Frase 8
                         new Amor()
                         {
                             Id = 8 , Frase = "La vida y la muerte son lo mismo, la única diferencia, eres tú. "

                         },

                         //Frase 9
                         new Amor()
                         {
                             Id = 9 , Frase = "Si con una mirada mataras, yo hace tiempo que estaría en la tumba. "

                         },

                         // Frase 10
                         new Amor()
                         {
                             Id = 10 , Frase = "Amor es haber elegido a alguien y volverlo a elegir todos los días..."

                         },

                         // Frase 11
                         new Amor()
                         {
                             Id = 11 , Frase = "El amor es como el mar, se ve el principo, pero nunca el final."

                         },

                         // Frase 12
                         new Amor()
                         {
                             Id = 12 , Frase = "La gente se arregla todos los días el cabello. ¿Por qué no el corazón?"

                         },

                         // Frase 13
                         new Amor()
                         {
                             Id = 13 , Frase = "El corazón es un niño: espera lo que desea."

                         },

                         // Frase 14
                         new Amor()
                         {
                             Id = 14 , Frase = "Es verdad que se necesita un corazón para vivir, pero más te necesito a ti que lo haces latir."

                         },

                         // Frase 15
                         new Amor()
                         {
                             Id = 15 , Frase = "Cada uno tiene la edad de su corazón."

                         },

                         // Frase 16
                         new Amor()
                         {
                             Id = 16 , Frase = "Nuestro corazón tiene la edad de aquello que ama."

                         },

                         // Frase 17
                         new Amor()
                         {
                             Id = 17 , Frase = "La fuente de la vida es el corazón."

                         },

                         // Frase 18
                         new Amor()
                         {
                             Id = 18 , Frase = "Tratemos de ver con el corazón."

                         },

                         // Frase 19
                         new Amor()
                         {
                             Id = 19 , Frase = "No importa el exterior... tampoco el interior."

                         },

                         // Frase 20
                         new Amor()
                         {
                             Id = 20 , Frase = "Si quieres saber cuanto te quiero cuenta las estrellas del cielo..."

                         },

                         // Frase 21
                         new Amor()
                         {
                             Id = 21 , Frase = "Mi cielo es tu cuerpo, mi sueño tu sonrisa, mi droga tus besos, mi obsesión tus caricias, mi camino tu felicidad y mi objetivo... tu amor."

                         },

                         // Frase 22
                         new Amor()
                         {
                             Id = 22 , Frase = "La única forma de estar contigo es en sueños, así podré besarte y brazarte en ellos."

                         },

                         // Frase 23
                         new Amor()
                         {
                             Id = 23 , Frase = "Cuando se ama es el corazón quien juzga."

                         },

                         // Frase 24
                         new Amor()
                         {
                             Id = 24 , Frase = "Si muero sin conocerte no muero, porque no he vivido. "

                         },

                         // Frase 25
                         new Amor()
                         {
                             Id = 25 , Frase = "El amor no es del que lo busca, sino del que se lo encuentra."

                         },

                         // Frase 26
                         new Amor()
                         {
                             Id = 26 , Frase = "No me preguntes porqué te amo, tendría que explicarte porqué vivo."

                         },

                         // Frase 27
                         new Amor()
                         {
                             Id = 27 , Frase = "No pienses que te amo, porque te amo más de lo que puedas pensar."

                         },

                         // Frase 28
                         new Amor()
                         {
                             Id = 28 , Frase = "Con besos de mermelada y abrazos de mantequilla, te envío todo mi amor envuelto en una tortilla."

                         },

                         // Frase 29
                         new Amor()
                         {
                             Id = 29 , Frase = "Alguien que ama no insulta ni maltrata."

                         },

                         // Frase 30
                         new Amor()
                         {
                             Id = 30 , Frase = "La belleza que atrae rara vez coincide con la belleza que enamora."

                         },

                         // Frase 31
                         new Amor()
                         {
                             Id = 31 , Frase = "Eres tan parecida a un sueño, que cuando no estás, no se si he estado contigo, o te he soñado. "

                         },

                         // Frase 32
                         new Amor()
                         {
                             Id = 32 , Frase = "Si el amor es difícil de explicar, lo mio es imposible."

                         },

                         // Frase 33
                         new Amor()
                         {
                             Id = 33 , Frase = "Hay que escuchar a la cabeza, pero dejar hablar al corazón."

                         },

                         // Frase 34
                         new Amor()
                         {
                             Id = 34 , Frase = "Un corazón es una riqueza que no se vende ni se compra, pero que se regala."

                         },

                         // Frase 35
                         new Amor()
                         {
                             Id = 35 , Frase = "La peor prisión es un corazón cerrado."

                         },

                         // Frase 36
                         new Amor()
                         {
                             Id = 36 , Frase = "El pasado como el amor no correspondido, es mejor enterrarlo vivo."

                         },

                         // Frase 37
                         new Amor()
                         {
                             Id = 37 , Frase = "El amor no tiene cura, pero es la única medicina para todos los males."

                         },

                         // Frase 38
                         new Amor()
                         {
                             Id = 38 , Frase = "La ausencia devuelve al amor lo que la costumbre le hizo perder."

                         },

                         // Frase 39
                         new Amor()
                         {
                             Id = 39 , Frase = "Amor es elegir a alguien, volverlo a elegir cada día y compartir sueños."

                         },

                         // Frase 40
                         new Amor()
                         {
                             Id = 40 , Frase = "No te fijes en mi cuerpo, ni en mi cara, ni tampoco en mi figura, solo fíjate en mi corazón que te ama con locura."

                         },

                          // Frase 41
                         new Amor()
                         {
                             Id = 41 , Frase = "Purifica tu corazón antes de permitir que el amor se asiente en él, ya que la miel más dulce se agria en un vaso sucio."

                         },

                          // Frase 42
                         new Amor()
                         {
                             Id = 42 , Frase = "El corazón tiene razones que la razón ignora."

                         },

                          // Frase 43
                         new Amor()
                         {
                             Id = 43 , Frase = "Amar es un fuego escondido, una agradable llaga, un sabroso veneno, una dulce amargura, una deleitable dolencia, un alegre tormento, un riesgo que vale la pena"

                         },

                          // Frase 44
                         new Amor()
                         {
                             Id = 44 , Frase = "El problema del hombre no está en la bomba atómica, sino en su corazón."

                         },

                          // Frase 45
                         new Amor()
                         {
                             Id = 45 , Frase = "Nada pesa tanto como el corazón cuando está cansado."

                         },

                          // Frase 46
                         new Amor()
                         {
                             Id = 46 , Frase = "Un corazón grande se llena con poco."

                         },

                          // Frase 47
                         new Amor()
                         {
                             Id = 47 , Frase = "Ama a quien te ama, no a quien te ilusiona. "

                         },

                          // Frase 48
                         new Amor()
                         {
                             Id = 48 , Frase = "Quien no comprende una mirada, nunca entenderá una explicación."

                         },

                          // Frase 49
                         new Amor()
                         {
                             Id = 49 , Frase = "He dejado de saber quien soy por intertar conocerte. "

                         },

                          // Frase 50
                         new Amor()
                         {
                             Id = 50 , Frase = "El que tiene buen corazón nunca es estúpido."

                         },

                         // Frase 51
                         new Amor()
                         {
                             Id = 51 , Frase = "A la escuela del amor de la mano me llevaste, y a la primera clase el corazón me robaste."

                         },

                         // Frase 52
                         new Amor()
                         {
                             Id = 52 , Frase = "Amar es dar a una persona el poder para destruirte, y confiar en que no lo hará"

                         },

                         // Frase 53
                         new Amor()
                         {
                             Id = 53 , Frase = "Sin ti los segundos transcurren como un anochecer repentino, sin ti mis sentimientos caen al vacío de la tristeza, sin ti mis lagrimas nacen solitarias y frágiles...sin ti"

                         },

                         // Frase 54
                         new Amor()
                         {
                             Id = 54 , Frase = "El hombre y la mujer han nacido para amarse, pero no para vivir juntos. Los amantes célebres de la historia vivieron siempre separados."

                         },

                         // Frase 55
                         new Amor()
                         {
                             Id = 55 , Frase = "Para un amante ya no hay amigos."

                         },

                         // Frase 56
                         new Amor()
                         {
                             Id = 56 , Frase = "En los inicios de un amor los amantes hablan del futuro, en sus postrimerías, del pasado."

                         },

                         // Frase 57
                         new Amor()
                         {
                             Id = 57 , Frase = "Te amo para amarte y no para ser amado, puesto que nada me place tanto como verte a ti feliz."

                         },

                         // Frase 58
                         new Amor()
                         {
                             Id = 58 , Frase = "Amarás a quien no te ama por no haber amado a quien te amó. "

                         },

                         // Frase 59
                         new Amor()
                         {
                             Id = 59 , Frase = "Si fui un resbalón en tu camino, yo no te culpo, porque fui un ciego en creer en tu amor. "

                         },

                         // Frase 60
                         new Amor()
                         {
                             Id = 60 , Frase = "Lo único que necesito es un abrazo, y una mirada que aun sin leer tus labios, expresen un te quiero."

                         },

                         // Frase 61
                         new Amor()
                         {
                             Id = 61 , Frase = "Ciegos son los ojos que no detallan la dulzura en la superficie de tu piel."

                         },

                         // Frase 62
                         new Amor()
                         {
                             Id = 62 , Frase = "Una nube blanca, una nube azul, en la nube un sueño y en el sueño tú."

                         },

                         // Frase 63
                         new Amor()
                         {
                             Id = 63 , Frase = "Nunca llores por culpa de un querer, porque ningún hombre se merece lágrimas de una mujer."

                         },

                         // Frase 64
                         new Amor()
                         {
                             Id = 64 , Frase = "El amor es bello, el amor es triste, pero aunque bello y triste el amor existe."

                         },

                         // Frase 65
                         new Amor()
                         {
                             Id = 65 , Frase = "Te amo y no lo niego, sólo lo escondo."

                         },

                         // Frase 66
                         new Amor()
                         {
                             Id = 66 , Frase = "El que ha conocido sólo a su mujer y la ha amado, sabe más de mujeres que el que ha conocido mil."

                         },

                         // Frase 67
                         new Amor()
                         {
                             Id = 67 , Frase = "Amar no es mirarse el uno al otro; es mirar juntos en la misma dirección."

                         },

                         // Frase 68
                         new Amor()
                         {
                             Id = 68 , Frase = "Amar es encontrar en la felicidad de otro tu propia felicidad."

                         },

                         // Frase 69
                         new Amor()
                         {
                             Id = 69 , Frase = "La medida del amor, es amar sin medida"

                         },

                         // Frase 70
                         new Amor()
                         {
                             Id = 70 , Frase = "No sé si te quiero, no sé si te amo, sólo sé que nesesito tenerte a mi lado"

                         },

                         // Frase 71
                         new Amor()
                         {
                             Id = 71 , Frase = "Viviré de tu amor, mi alimento serán nuestros besos, mi aire cada caricia de tus manos, mi energía la mirada de tus ojos, mi dormir será dormir a tu lado"

                         },

                         // Frase 72
                         new Amor()
                         {
                             Id = 72 , Frase = "Sé que no puedo volar, pero hay alguien que me hace sentir que lo puedo hacer, y esa persona eres tú"

                         },

                         // Frase 73
                         new Amor()
                         {
                             Id = 73 , Frase = "Si no recuerdas la más ligera locura en que el amor te hizo caer, no has amado."

                         },

                         // Frase 74
                         new Amor()
                         {
                             Id = 74 , Frase = "Nunca amamos a nadie: amamos, sólo, la idea que tenemos de alguien. Lo que amamos es un concepto nuestro, es decir, a nosotros mismos."

                         },

                         // Frase 75
                         new Amor()
                         {
                             Id = 75 , Frase = "Sólo se ama lo que no se posee totalmente."

                         },

                         // Frase 76
                         new Amor()
                         {
                             Id = 76 , Frase = "Amar a alguien es decirle: tú no morirás jamás."

                         },

                         // Frase 77
                         new Amor()
                         {
                             Id = 77 , Frase = "Pienso en ti y no encuentro un final feliz, maldigo el día en que te escogí."

                         },

                         // Frase 78
                         new Amor()
                         {
                             Id = 78 , Frase = "Es una locura amar, a menos de que se ame con locura."

                         },

                         // Frase 79
                         new Amor()
                         {
                             Id = 79 , Frase = "Sólo quiero que sepas que por ti yo mataría y por tu amor sobreviviría para poderte amar."

                         },

                         // Frase 80
                         new Amor()
                         {
                             Id = 80 , Frase = "Podré no verte, podré no hablarte, pero jamás podré olvidarte."

                         },

                          // Frase 81
                         new Amor()
                         {
                             Id = 81 , Frase = "Como hago para olvidarte, si cuando lo empiezo a lograr te vuelvo a ver."

                         },

                          // Frase 82
                         new Amor()
                         {
                             Id = 82 , Frase = "Ama a quien no te ama, responde a quien no te llama, andarás carrera vana."

                         },

                          // Frase 83
                         new Amor()
                         {
                             Id = 83 , Frase = "No ser amado es una simple desventura. La verdadera desgracia es no saber amar."

                         },

                          // Frase 84
                         new Amor()
                         {
                             Id = 84 , Frase = "Uno no puede hacer nada por las personas que ama, sólo seguir amándolas."

                         },

                          // Frase 85
                         new Amor()
                         {
                             Id = 85 , Frase = "Los hombres engañan más que las mujeres; las mujeres, mejor."

                         },

                          // Frase 86
                         new Amor()
                         {
                             Id = 86 , Frase = "En ninguna cosa la infidelidad es más innoble y repugnante que en el amor."

                         },

                          // Frase 87
                         new Amor()
                         {
                             Id = 87 , Frase = "La mujer perdona las infidelidades, pero no las olvida. El hombre olvida las infidelidades, pero no las perdona."

                         },

                          // Frase 88
                         new Amor()
                         {
                             Id = 88 , Frase = "Al primer amor se le quiere más, a los otros se les quiere mejor."

                         },

                          // Frase 89
                         new Amor()
                         {
                             Id = 89 , Frase = "La magia del primer amor consiste en nuestra ignorancia de que pueda tener fin."

                         },

                          // Frase 90
                         new Amor()
                         {
                             Id = 90 , Frase = "Soportaría gustosa una docena más de desencantos amorosos, si ello me ayudara a perder un par de kilos."

                         },

                         // Frase 91
                         new Amor()
                         {
                             Id = 91 , Frase = "Dicen que la distancia es causa del olvido, eso lo dice aquel que nunca a querido."

                         },

                         // Frase 92
                         new Amor()
                         {
                             Id = 92 , Frase = "Si Satanás pudiese amar, dejaría de ser diablo."

                         },

                         // Frase 93
                         new Amor()
                         {
                             Id = 93 , Frase = "El amor es como el Sol, se oculta pero no muere."

                         },

                         // Frase 94
                         new Amor()
                         {
                             Id = 94 , Frase = "El amor es lo que queda después de la atraccion física."

                         },

                         // Frase 95
                         new Amor()
                         {
                             Id = 95 , Frase = "El amor es libre, pero sin embargo hay carcel."

                         },

                         // Frase 96
                         new Amor()
                         {
                             Id = 96 , Frase = "Detengo el mundo cuando me miras, como me miras y robo suspiros al cielo por tus besos, pienso que no puedo amarte más y sin embargo, cada instante te amo más y más"

                         },

                         // Frase 97
                         new Amor()
                         {
                             Id = 97 , Frase = "Tengo frío, tengo calor, tengo todo menos tu amor."

                         },

                         // Frase 98
                         new Amor()
                         {
                             Id = 98 , Frase = "Uno no se enamoró nunca, y ése fue su infierno. Otro, sí, y ésa fue su condena."

                         },

                         // Frase 99
                         new Amor()
                         {
                             Id = 99 , Frase = "Un hombre enamorado está incompleto hasta que está casado; entonces está acabado."

                         },

                         // Frase 100
                         new Amor()
                         {
                             Id = 100 , Frase = "No olvides nunca que el primer beso no se da con la boca, sino con los ojos."

                         },

                       
                    };

                    dataContext.Amor.InsertAllOnSubmit(amorObj);
                    dataContext.SubmitChanges();
                    

                }






            }
        }



         
            

        

       
        // Botón compartir
        private void AplicationBarCompartir_Click(object sender, EventArgs e)
        {
            ShareStatusTask shareStatusTask = new ShareStatusTask();

            shareStatusTask.Status = BloqueTextoFrase.Text;

            shareStatusTask.Show();

        }
        // Botón acerca de
        private void ApplicationBarAcercaDe_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AcercaDe.xaml", UriKind.Relative));
        }


        
        private void BotonCorazon_Click(object sender, RoutedEventArgs e)
        {
        
            using (BaseDeDatosFrasesDataContext contextoDatos = new BaseDeDatosFrasesDataContext("Data source='isostore:/AmorDB.sdf'"))
            {
                Random aleatorio = new Random();
                int valor = 0;

                valor = aleatorio.Next(1, 100);
          

          
                var cont = contextoDatos.Amor.Where(c => c.Id == valor).FirstOrDefault();


                
      

                if (cont != null)
                {
                    BloqueTextoFrase.Text = cont.Frase;
                }

                cont = null;
            }

         
            
        }

       
        
    }
}