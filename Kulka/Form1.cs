/// <summary>
/// Projekt JPWP - Gra edukacyjna
/// </summary>
namespace Kulka
{
    /// <summary>
    /// Klasa odpowiedzialna za większą część gry
    /// </summary>
    public partial class Form1 : Form
    {
        //! Wymiar maksymalnej szerokości pola gry
        public int max_X = 505; //! Wymiar maksymalnej wysokości pola gry
        public int max_Y = 345; //! Wymiar minimalnej szerokości pola gry
        public int min_X = 195; //! Wymiar minimalnej wysokości pola gry
        public int min_Y = 72; //! Zmienna przechowująca ilość punktów
        public int score=0;

        //! Tablica przechowująca 9 możliwych kierunków ruchu przycisku
        public int[] direction = { -1, 0, 1 };

        private Random random = new Random();
        //! Zmienna losująca kierunek przemieszczania się przycisku
        public int which_direction_x; //! Zmienna losująca kierunek przemieszczania się przycisku
        public int which_direction_y;

        //! Czas gry
        public int _ticks = 30; 
        private int _ticks2;

        //! Automatyczne znikanie przycisku, gdy minie określona ilość czasu zależna od poziomu trudności
        public float dissapear;
        //! Aktualnie wybrany poziom
        public int choosing_lvl; 

        /// <summary>
        /// Inicjalizacja ważniejszych zmiennych
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            panel1.Location = new System.Drawing.Point(min_X-60, min_Y-60); 
            label_score.Text = "SCORE: " + score.ToString();
            label_time.Text = "TIME: " + _ticks.ToString();

            timer2.Interval = 50;
        }

        /// <summary>
        /// Struktura przechowująca zmienne używane do określenia pozycji przycisku
        /// </summary>
        public struct X_Y
        {
            //! Przechowywanie położenia w płaszczyźnie OX
            public int x;
            //! Przechowywanie położenia w płaszczyźnie OY
            public int y;
        };

        /// <summary>
        /// Losowanie nowej pozycji przycisku
        /// </summary>
        /// <returns>Zwrócenie struktury przechowującej wartości X i Y nowej pozycji przycisku</returns>
        public X_Y GetXY()
        {
            int rand_x = random.Next(min_X, max_X);
            int rand_y = random.Next(min_Y + 60, max_Y - 60);

            X_Y l = new X_Y();
            l.x = rand_x;
            l.y = rand_y;

            return l;
        }

        /// <summary>
        /// Umieszczenie przycisku w nowej pozycji i losowanie kierunku poruszania się przycisku
        /// </summary>
        public void place_circle()
        {
            X_Y l = GetXY();

            buttonEllipse2.Visible = false;

            buttonEllipse2.Location = new Point(l.x, l.y);
            buttonEllipse2.Visible = true;

            which_direction_x = random.Next(direction.Length);
            which_direction_y = random.Next(direction.Length);

            if (choosing_lvl == 0)
                dissapear = 3;
            else if (choosing_lvl == 1)
                dissapear = 2;
            else dissapear = 1.2f;
        }

        /// <summary>
        /// Po kliknieciu przycisku następuje wylosowanie nowej pozycji
        /// </summary>
        /// <param name="sender">Definicja obiektu klikalnego</param>
        /// <param name="e">Po wykonaniu zdarzenia klikniecia</param>
        private void buttonEllipse2_Click(object sender, EventArgs e)
        {
            place_circle();
            score++;
            label_score.Text = "SCORE: " + score.ToString();
        }

        /// <summary>
        /// Funkcja prezentująca stan po zakończonej rozgrywce i przepisująca najlepszy wynik w odpowiednie pole.
        /// </summary>
        public void end_Game()
        {
            if (choosing_lvl == 0)
                label_topEasy.Text = "TOP SCORE: " + score.ToString();
            else if(choosing_lvl == 1)
                label_topMedium.Text = "TOP SCORE: " + score.ToString();
            else label_topHard.Text = "TOP SCORE: " + score.ToString();


            unlock_buttons();

        }

        /// <summary>
        /// Funkcja odmierzająca czas gry i odpowiadająca za zniknięcie przycisku po odpowiednim czasie
        /// </summary>
        /// <param name="sender">Definicja obiektu</param>
        /// <param name="e">Po wykonaniu zdarzenia klikniecia</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            label_time.Text = "TIME: " + _ticks.ToString();
            if(_ticks <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                end_Game();
            }

            if (choosing_lvl == 2)
                dissapear -= 0.99f;
            else dissapear--;
            if(dissapear <= 0.2f)
            {
                place_circle();
            }
        }

        //! Zmiana pozycji przycisku
        public Point temp;

        /// <summary>
        /// Funkcja odpowiedzialna za przemieszczanie się przycisku
        /// </summary>
        /// <param name="sender">Definicja obiektu klikalnego</param>
        /// <param name="e">Po wykonaniu zdarzenia klikniecia</param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks2++;
            int lox_x = buttonEllipse2.Location.X;
            int lox_y = buttonEllipse2.Location.Y;

            if (lox_x > max_X)
                which_direction_x=-1;
            if (lox_x < min_X)
                which_direction_x=1;
            if(lox_y > max_Y)
                which_direction_y=-1;
            if(lox_y < min_Y)
                which_direction_y=1;

            
            temp = new Point(lox_x+which_direction_x, lox_y+which_direction_y); 
            buttonEllipse2.Location = temp;
        }

        /// <summary>
        /// Po rozpoczęciu rozgrywki nie można jej przerwać
        /// </summary>
        public void lock_buttons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            score = 0;
            label_score.Text = "SCORE: " + score.ToString();
        }

        /// <summary>
        /// Po zakończonej rozgrywce możliwość rozegrania kolejnej gry.
        /// Ustawienie wartości początkowych
        /// </summary>
        public void unlock_buttons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            
            _ticks = 30;

            score = 0;
            label_score.Text = "SCORE: " + score.ToString();

            label_time.Text = "TIME: " + _ticks.ToString();
        }

        /// <summary>
        /// Wybór łatwego poziomu trudności
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            dissapear = 3;
            choosing_lvl = 0;
            lock_buttons();
        }

        /// <summary>
        /// Wybór średniego poziomu trudności
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            dissapear = 2;
            choosing_lvl = 1;
            lock_buttons();
        }

        /// <summary>
        /// Wybór trudnego poziomu rozgrywki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            dissapear = 1;
            choosing_lvl = 2;
            lock_buttons();
        }
    }
}