using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A Basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Load Method
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Control Button Methods

        /// <summary>
        /// CE Button method to clear textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the textbox
            this.UserImputText.Text = string.Empty;

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// C Button method to remove one value before the cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CButton_Click(object sender, EventArgs e)
        {
            //Removes one value before the cursor
            BackspaceTextValue(1);

            //Focus back to imput textbox
            Focus_On_Textbox();

        }

        /// <summary>
        /// Del Button method to remove one value after the cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelButton_Click(object sender, EventArgs e)
        {
            //Removes one value after the cursor
            DeleteTextValue(1);
        }

        #endregion

        #region Digits Methods

        /// <summary>
        /// Methods carried out on click on Button1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            // Inserts " 1 " to equation in selectionstart position
            InsertTextValue("1");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            // Inserts " 2 " to equation in selectionstart position
            InsertTextValue("2");
            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            // Inserts " 3 " to equation in selectionstart position
            InsertTextValue("3");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            // Inserts " 4 " to equation in selectionstart position
            InsertTextValue("4");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            // Inserts " 5 " to equation in selectionstart position
            InsertTextValue("5");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            // Inserts " 6 " to equation in selectionstart position
            InsertTextValue("6");
        }

        /// <summary>
        /// Methods carried out on click on Button7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, EventArgs e)
        {
            // Inserts " 7 " to equation in selectionstart position
            InsertTextValue("7");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            // Inserts " 8 " to equation in selectionstart position
            InsertTextValue("8");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button9_Click(object sender, EventArgs e)
        {
            // Inserts " 9 " to equation in selectionstart position
            InsertTextValue("9");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on Button0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button0_Click(object sender, EventArgs e)
        {
            // Inserts " 0 " to equation in selectionstart position
            InsertTextValue("0");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }
        #endregion

        #region Coma and blank Button Methods

        /// <summary>
        /// Inserts dot to equation in selectionstart position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComaButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            //Focus back to input textbox
            Focus_On_Textbox();
        }
        
       
        #endregion

        #region Operator Methods

        /// <summary>
        /// Methods carried out on click on PercentButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentButton_Click(object sender, EventArgs e)
        {
            // Inserts " % " to equation in selectionstart position
            InsertTextValue("%");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }


        /// <summary>
        /// Methods carried out on click on DivideButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            // Inserts " / " to equation in selectionstart position
            InsertTextValue("/");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on MultiplyButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            // Inserts " * " to equation in selectionstart position
            InsertTextValue("*");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on SubstractButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubstractButton_Click(object sender, EventArgs e)
        {
            // Inserts " - " to equation in selectionstart position
            InsertTextValue("-");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on AddButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Inserts " + " to equation in selectionstart position
            InsertTextValue("+");

            //Focus back to imput textbox
            Focus_On_Textbox();
        }

        /// <summary>
        /// Methods carried out on click on EqualsButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        
        #endregion

        #region Calculate Eqation Method
        /// <summary>
        /// Method calculating equation from textbox and outputs result
        /// </summary>

        private void CalculateEquation()
        {
            this.CalculationResultText.Text = ParseOperation();
        }


        /// <summary>
        /// Parses the users imput and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try 
            {
                //Get user equation input 
                var userInput = this.UserImputText.Text;

                //Remove all spaces

                userInput = userInput.Replace(" ","");

                //Create new top level operation
                var operation = new Operation();
                var leftSide = true;

                //Loop through each character in the userImput string
                for (int i = 0; i < userInput.Length; i++)
                {
                    //Check if th current character is the number
                    if("1234567890.".Any(c=> userInput[i]==c))
                    {
                        if (leftSide)
                            operation.leftSide = AddNumberPart(operation.leftSide, userInput[i]);
                        else
                            operation.rightSide = AddNumberPart(operation.rightSide, userInput[i]);
                    }
                    //It there is an operatot(+ - * /) set the operotor type
                    else if ("+-*/".Any(c => userInput[i] == c))
                    {
                        //If we are already on right siede we need to calculate current operation and set ther result to the left side for next operation
                        if(!leftSide)
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(userInput[i]);

                            //Check if we actually have right side
                            if (operation.rightSide.Length == 0)
                            {
                                //Check the operator if it is not a minus(could be negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operatot spcified without right side number");

                                //Operator type is the minus and there is no right side so add minus to the number
                                operation.rightSide += userInput[i];
                            }
                            else
                            {
                                //Calculate previous equation and set to the left side
                                operation.leftSide = CalculateOperation(operation);

                                //Set the new operator
                                operation.OperationType = operatorType;

                                //Clear the previous right number
                                operation.rightSide = string.Empty;
                            }    
                        }
                        else
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(userInput[i]);

                            //Check if we actually have left side
                            if (operation.leftSide.Length==0)
                            {
                                //Check the operator if it is not a minus(could be negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operatot spcified without left side number");

                                //Operator type is the minus and there is no left side so add minus to the number
                                operation.leftSide += userInput[i];
                            }
                            else
                            {
                                //If we get here we have left number and operator, we want to move to right side

                                //Set the operation type
                                operation.OperationType = operatorType;

                                //Move to right side
                                leftSide = false;
                            }

                        }
                    }


                }
                //If we are done parsing and there are no exceptions calculate the current operation
                return CalculateOperation(operation);

            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates an <see cref="operation" /> and returns the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            //Store number values of the string representations
            double left = 0;
            double right = 0;

            //Check if we have valid left side number
            if (string.IsNullOrEmpty(operation.leftSide) || !double.TryParse(operation.leftSide, out left))
                throw new InvalidOperationException($"Left side of the oparation was not a valid number. {operation.leftSide} ");

            //Check if we have valid right side number
            if (string.IsNullOrEmpty(operation.rightSide) || !double.TryParse(operation.rightSide, out right))
                throw new InvalidOperationException($"Right side of the oparation was not a valid number. {operation.rightSide} ");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operatortype when calculating equation. {operation.OperationType}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Falied calculating equation. {operation.leftSide}{operation.OperationType}{operation.rightSide}. {ex.Message}");
            }
        }

        /// <summary>
        /// Accepts a character and returns known <see cref= "OperationType"/see>
        /// </summary>
        /// <param name="character">The character to parse </param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch(character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus; ;
                case '*':
                    return OperationType.Multiply; ;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");

            }
        }

        /// <summary>
        /// Attempts to ad new character to current number, checking if it's valid
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.')) 
            throw new InvalidOperationException($"Number {currentNumber} leady contains a . and another can't be added");

            return currentNumber + newCharacter;
        }
        #endregion

        #region Private Helpers

        /// <summary>
        /// Focus on imput textbox
        /// </summary>
        private void Focus_On_Textbox()
        {
            // Focus cursor on imput textbox
            this.UserImputText.Focus();
        }

        /// <summary>
        /// Inserts given imput to textbox
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            //Remember SelectionStart
            var selectionStart = this.UserImputText.SelectionStart;

            //Set new text, replaces old text with the same text with insertion
            this.UserImputText.Text = this.UserImputText.Text.Insert(this.UserImputText.SelectionStart, value);
            
            //Restore SelectionStart
            this.UserImputText.SelectionStart = selectionStart+value.Length;

            //Set selection/lenght to zero
            this.UserImputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes one char after SelectionStart from texbox
        /// </summary>
        /// <param name="v"></param>
        private void DeleteTextValue(int y)
        {
            //Check if there is something to delete to the right from SelectionStart, return if no
            if (this.UserImputText.Text.Length < this.UserImputText.SelectionStart + 1)
                return;

            //Remember Selection Start
            var selectionStart = this.UserImputText.SelectionStart;

            //Delete char to the roght from selectionStart
            this.UserImputText.Text = this.UserImputText.Text.Remove(this.UserImputText.SelectionStart, y);

            //Restore SelectionStart position
            this.UserImputText.SelectionStart = selectionStart;

            // Set selection / lenght to zero
            this.UserImputText.SelectionLength = 0;
        }
        

        /// <summary>
        /// Deletes one char before SelectionStart from texbox
        /// </summary>
        /// <param name="v"></param>
        private void BackspaceTextValue(int y)
        {
            //Check if there is something to delete to the right from SelectionStart, return if no
            if ((this.UserImputText.Text.Length < 1) ||( this.UserImputText.SelectionStart<1))
                return;

            //Remember Selection Start
            var selectionStart = this.UserImputText.SelectionStart;

            //Delete one value to the right from selectionStart
            this.UserImputText.Text = this.UserImputText.Text.Remove(this.UserImputText.SelectionStart-1, y);

            //Restore SelectionStart position
            this.UserImputText.SelectionStart = selectionStart-1;

            // Set selection  lenght to zero
            this.UserImputText.SelectionLength = 0;
        }

        #endregion

      
    }
}
