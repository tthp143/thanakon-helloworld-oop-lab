# Calculator

by Thanakon Thipanet,
673450191-2,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click_1(object sender, EventArgs e)
{
    var Num1 = num1.Text;
    var Num2 = num2.Text;

    double n1 = Double.Parse(Num1);
    double n2 = Double.Parse(Num2);
    double sum = n1 + n2;

    result.Text = sum.ToString();
}
```

### รับข้อมูล

ตัวอย่าง

```
{
var Num1 = num1.Text;
}
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
{
double n1 = Double.Parse(Num1);
double n2 = Double.Parse(Num2);
}
```

### คำนวนผลลัพท์

ตัวอย่าง

```
double sum = n1 - n2;
double sum = n1 + n2;
```

### แสดงผล

ตัวอย่าง

```
{
    num1.Text = "";
}
```

## ปุ่มลบ
private void button2_Click(object sender, EventArgs e)
{
    var Num1 = num1.Text;
    var Num2 = num2.Text;

    double n1 = Double.Parse(Num1);
    double n2 = Double.Parse(Num2);
    double sum = n1 - n2;

    result.Text = sum.ToString();
}

## ปุ่มคูณ
private void button3_Click(object sender, EventArgs e)
{
    var Num1 = num1.Text;
    var Num2 = num2.Text;

    double n1 = Double.Parse(Num1);
    double n2 = Double.Parse(Num2);
    double sum = n1 * n2;

    result.Text = sum.ToString();
}
## ปุ่มหาร
private void button4_Click(object sender, EventArgs e)
{
    var Num1 = num1.Text;
    var Num2 = num2.Text;

    double n1 = Double.Parse(Num1);
    double n2 = Double.Parse(Num2);
    double sum = n1 / n2;

    result.Text = sum.ToString();
}
## ปุ่มลบข้อมูล
private void Button5_Click(object sender, EventArgs e)
{
    num1.Text = "";
    num2.Text = "";
    result.Text = "";
}