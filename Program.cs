using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string xmove;
            string omove;

            string oname;
            string xname;

            int xCount = 0;
            int oCount = 0;

            int winnerIndicator;

            // create board
            List<string> board = new List<string>();
            board.Add("7");
            board.Add("8");
            board.Add("9");
            board.Add("4");
            board.Add("5");
            board.Add("6");
            board.Add("1");
            board.Add("2");
            board.Add("3");
            // dispplay board
            void displayboard(){
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{board[0]} | {board[1]} | {board[2]} ");
                Console.WriteLine($"- + - + - ");
                Console.WriteLine($"{board[3]} | {board[4]} | {board[5]} ");
                Console.WriteLine($"- + - + - ");
                Console.WriteLine($"{board[6]} | {board[7]} | {board[8]} ");
            }
            // update board after players "x" turn
            void xmoveUpdate(){
                if (xmove == board[0]){
                    board[0] = "x";
                }else if (xmove == board[1]){
                    board[1] = "x";
                }else if (xmove == board[2]){
                    board[2] = "x";
                }else if (xmove == board[3]){
                    board[3] = "x";
                }else if (xmove == board[4]){
                    board[4] = "x";
                }else if (xmove == board[5]){
                    board[5] = "x";
                }else if (xmove == board[6]){
                    board[6] = "x";
                }else if (xmove == board[7]){
                    board[7] = "x";
                }else if (xmove == board[8]){
                    board[8] = "x";
                }else {
                    Console.WriteLine("Please enter a number between 1 and 9");
            }}
            // update board after players "o" turn
            void omoveUpdate(){
                if (omove == board[0]){
                    board[0] = "o";
                }else if (omove == board[1]){
                    board[1] = "o";
                }else if (omove == board[2]){
                    board[2] = "o";
                }else if (omove == board[3]){
                    board[3] = "o";
                }else if (omove == board[4]){
                    board[4] = "o";
                }else if (omove == board[5]){
                    board[5] = "o";
                }else if (omove == board[6]){
                    board[6] = "o";
                }else if (omove == board[7]){
                    board[7] = "o";
                }else if (omove == board[8]){
                    board[8] = "o";
                }else {
                    Console.WriteLine("Please enter a number between 1 and 9");
                }}
            // if x is winner winnerIndicator will be 1
            // if o is winner winnerIndicator will be 2
            // if it's a tie winnerIndicator will be 3
            // else switch player winnerIndicator will be 0
            int isWinner(){
                if (board[0] == "x" && board[1] == "x" && board[2] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[3] == "x" && board[4] == "x" && board[5] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[6] == "x" && board[7] == "x" && board[8] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[0] == "x" && board[3] == "x" && board[6] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[1] == "x" && board[4] == "x" && board[7] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[2] == "x" && board[5] == "x" && board[8] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[0] == "x" && board[4] == "x" && board[8] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }else if (board[6] == "x" && board[4] == "x" && board[2] == "x"){
                    winnerIndicator = 1;
                    Console.WriteLine($"{xname} WON!");
                }
                
                else if (board[0] == "o" && board[1] == "o" && board[2] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[3] == "o" && board[4] == "o" && board[5] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[6] == "o" && board[7] == "o" && board[8] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[0] == "o" && board[3] == "o" && board[6] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[1] == "o" && board[4] == "o" && board[7] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[2] == "o" && board[5] == "o" && board[8] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[0] == "o" && board[4] == "o" && board[8] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (board[6] == "o" && board[4] == "o" && board[2] == "o"){
                    winnerIndicator = 2;
                    Console.WriteLine($"{oname} WON!");
                }else if (oCount == 4){
                    winnerIndicator = 3;
                    Console.WriteLine("It's Tie!");
                }else {
                    winnerIndicator = 0;// switch player
                    }
                return winnerIndicator;
            }
            // get's the name of the player x, gets input, updates the board,
            // and displays the new board.
            void Xturn(){
                Console.WriteLine($"{xname}'x' Your Turn!");
                xmove = Console.ReadLine();
                xCount ++;
                xmoveUpdate();
                displayboard();
            }
            // get's the name of the player o, gets input, updates the board,
            // and displays the new board.
            void oturn(){
                Console.WriteLine($"{oname}'o' Your Turn!");
                omove = Console.ReadLine();
                oCount += 1;
                omoveUpdate();
                displayboard();
            }
            //greets, asks for players names, and displays board
            void introduction(){
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Let's play Tic-Tac-Toe!");
                Console.WriteLine("Player 'x' What is your name?");
                xname = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Player 'o' What is your name?");
                oname = Console.ReadLine();
                Console.WriteLine();
                displayboard();
            } 
            // switches playes by counting how many turns each player has
            void switchPlayer(){
                if (oCount < xCount){
                    oturn();
                }else if (oCount == xCount){
                    Xturn();
                }}
            // sets the board back to the main position for the next game
            void cleanBoard(){
                    board[0] = "7";
                    board[1] = "8";
                    board[2] = "9";
                    board[3] = "4";
                    board[4] = "5";
                    board[5] = "6";
                    board[6] = "1";
                    board[7] = "2";
                    board[8] = "3";
                    oCount = 0;
                    xCount = 0;
            }
            // offers to play again or close the end the game. 
            void gameover(){
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain == "y"){
                    cleanBoard();
                    game();
                }else if (playAgain == "n"){
                    Console.WriteLine("Til next time!");
                }else if (playAgain != "y" && playAgain != "n"){
                    Console.WriteLine("Please answer with 'Y' for yes or 'n' for no ");
                    gameover();
                }
            }
            // calls all the previous funcions in the right order to have
            // a fluid game. 
            void game(){

                introduction();
                Xturn();
                while (isWinner() == 0){
                    switchPlayer();
                }
                gameover();

                }
            game();
    }}}
    
