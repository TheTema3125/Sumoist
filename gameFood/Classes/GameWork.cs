using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameFood.Classes;

namespace gameFood.Classes
{
    public class GameWork
    {
        /// <summary>
        /// Класс для создания персонажа и начала игры.
        /// </summary>

        private bool GameStatus = true;

        public void GameStart(GameField gameField)
        {
            CreateHero(gameField.width, gameField.height);
        }

        private void CreateHero(int width, int height)
        {

        }
    }
}
