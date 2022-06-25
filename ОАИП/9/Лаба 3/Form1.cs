using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_4
{
    public partial class Form1 : Form
    {
        Square square;
        Circle circle;
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        bool flag = true;
        string name;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.bitmap = bitmap;
            Pen pen = new Pen(Color.Black, 2);
            Init.pen = pen;
            Init.pictureBox = pictureBox1;
            textBoxInputString.Text = "S(x,200,100,150)";
        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'S' || item == 'C' || item == 'M' || item == 'D' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ConvertCharToInt(object item)
        {
            return Convert.ToInt32(Convert.ToString(item));
        }
        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators = new Stack<Operator>();
                operands = new Stack<Operand>();
                for (int i = 0; i < textBoxInputString.Text.Length; i++)
                {
                    if (IsNotOperation(textBoxInputString.Text[i]))
                    {
                        if (!(Char.IsDigit(textBoxInputString.Text[i])))
                        {
                            this.operands.Push(new Operand(textBoxInputString.Text[i]));
                            continue;
                        }
                        else if (Char.IsDigit(textBoxInputString.Text[i]))
                        {
                            if (flag)
                            {
                                this.operands.Push(new Operand(textBoxInputString.Text[i]));
                            }
                            else
                            {
                                if (!(Char.IsDigit(textBoxInputString.Text[i - 1])))
                                {
                                    this.operands.Push(new Operand(ConvertCharToInt(textBoxInputString.Text[i])));
                                    continue;
                                }
                                this.operands.Push(new Operand(ConvertCharToInt(this.operands.Pop().value) * 10 + ConvertCharToInt(textBoxInputString.Text[i])));
                            }
                            flag = false;
                            continue;
                        }
                    }
                    else if (textBoxInputString.Text[i] == ',')
                    {
                        flag = true;
                        continue;
                    }
                    else if (textBoxInputString.Text[i] == 'S')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBoxInputString.Text[i]));
                        continue;
                    }
                    else if (textBoxInputString.Text[i] == 'C')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBoxInputString.Text[i]));
                        continue;
                    }
                    else if (textBoxInputString.Text[i] == 'M')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBoxInputString.Text[i]));
                        continue;
                    }
                    else if (textBoxInputString.Text[i] == 'D')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBoxInputString.Text[i]));
                        continue;
                    }
                    else if (textBoxInputString.Text[i] == '(')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBoxInputString.Text[i]));
                    }
                    else if (textBoxInputString.Text[i] == ')')
                    {
                        do
                        {
                            if (operators.Peek().symbolOperator == '(')
                            {
                                operators.Pop();
                                break;
                            }
                            if (operators.Count == 0)
                            {
                                break;
                            }
                        }
                        while (operators.Peek().symbolOperator != '(');
                    }
                }
                try
                {
                    this.SelectingPerformingOperation(operators.Peek());
                }
                catch
                {
                    MessageBox.Show("Введенной операции не существует");
                    comboBox1.Items.Add("Введена ошибочная команда");
                }
            }
        }
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'S')
            {
                if (this.operands.Count == 4)
                {
                    try
                    {
                        square = new Square(Convert.ToInt32(Convert.ToString(operands.Pop().value)), Convert.ToInt32(Convert.ToString(operands.Pop().value)), 
                            Convert.ToInt32(Convert.ToString(operands.Pop().value)), Convert.ToString(operands.Pop().value));
                        op = new Operator(square.Draw, 'S');
                        ShapeContainer.AddFigure(square);
                        comboBox1.Items.Add(square.createname);
                        op.operatorMethod();
                        square.Draw();
                    }
                    catch
                    {
                        MessageBox.Show("Возникла какая-то ошибка. Проверьте вводимые символы");
                        comboBox1.Items.Add("Введена ошибочная команда");
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте вводимые сиволы. Количество параметром должно быть равно четырём");
                    comboBox1.Items.Add("Введена ошибочная команда");
                }
            }
            if (op.symbolOperator == 'C')
            {
                if (this.operands.Count == 4)
                {
                    try
                    {
                        circle = new Circle(Convert.ToInt32(Convert.ToString(operands.Pop().value)), Convert.ToInt32(Convert.ToString(operands.Pop().value)),
                            Convert.ToInt32(Convert.ToString(operands.Pop().value)), Convert.ToString(operands.Pop().value));
                        op = new Operator(circle.Draw, 'C');
                        ShapeContainer.AddFigure(circle);
                        comboBox1.Items.Add(circle.createcircle);
                        op.operatorMethod();
                        circle.Draw();
                    }
                    catch
                    {
                        MessageBox.Show("Возникла какая-то ошибка. Проверьте вводимые символы");
                        comboBox1.Items.Add("Введена ошибочная команда");
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте вводимые сиволы. Количество параметром должно быть равно четырём");
                    comboBox1.Items.Add("Введена ошибочная команда");
                }
            }
            if (op.symbolOperator == 'M')
            {
                try
                {
                    int y = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                    int x = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                    name = Convert.ToString(operands.Pop().value);
                    string movename = "Квадрат " + name + " переместился";
                    if (ShapeContainer.FindFigure(name) == null)
                    {
                        MessageBox.Show("Возникла какая-то ошибка. Проверьте вводимые символы");
                        comboBox1.Items.Add("Введена ошибочная команда");
                    }
                    else
                    {
                        ShapeContainer.FindFigure(name).MoveTo(x, y);
                        if (comboBox1.Items.Contains(movename))
                        {
                            comboBox1.Items.Remove(movename);
                        }
                        comboBox1.Items.Add(movename);
                    }
                }
                catch
                {
                    MessageBox.Show("Возникла какая-то ошибка. Проверьте вводимые символы");
                    comboBox1.Items.Add("Введена ошибочная команда");
                }
            }
            if (op.symbolOperator == 'D')
            {
                try
                {
                    name = Convert.ToString(operands.Pop().value);
                    string deletename = "Квадрат " + name + " удалился";
                    if (ShapeContainer.FindFigure(name) == null)
                    {
                        MessageBox.Show("Возникла какая-то ошибка. Проверьте вводимые символы");
                        comboBox1.Items.Add("Введена ошибочная команда");
                    }
                    else
                    {
                        ShapeContainer.FindFigure(name).DeleteF(ShapeContainer.FindFigure(name), true);
                        comboBox1.Items.Add(ShapeContainer.FindFigure(name) + deletename);
                    }
                }
                catch
                {
                    MessageBox.Show("Возникла какая-то ошибка. Проверьте вводимые символы");
                    comboBox1.Items.Add("Введена ошибочная команда");
                }
            }
        }
    }
}
