using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace оаип_1_лаба
{
public partial class Form6 : Form
{
public Form6()
{
InitializeComponent();
}

private void button1_Click(object sender, EventArgs e)
{
int[] a = { 3, 4, 9, 5, 8, 2, 3, 1, 2, 6 };
for(int i=0; i<10; i++) {
label2.Text += String.Format("{0} ", a[i]);
}
int max_one = a[0], max_two = a[9], z;
for(int i=0; i<10; i++) {
if (max_one < a[i]) {
max_one = a[i];
}
}
for(int i=0; i<10; i++) {
if(max_two < a[i] && a[i] != max_one) {
max_two = a[i];
}
}
for(int i=0; i<10; i++) {
if(max_one == a[i]) {
z = a[0];
a[0] = a[i];
a[i] = z;
}
if(max_two == a[i]) {
z = a[9];
a[9] = a[i];
a[i] = z;
}
}
for(int i=0; i<10; i++) {
label4.Text += String.Format("{0} ", a[i]);
}
}
}
}