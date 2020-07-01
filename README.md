# tpn6-RoblesJP  
### PUNTO 4
**¿String es una tipo por valor o un tipo por referencia?**  
`string` es un tipo de valor por referencia  

**¿Qué secuencias de escape tiene el tipo string?**  
\\' - single quote, needed for character literals  
\\" - double quote, needed for string literals  
\\\ - backslash  
\0 - Unicode  
\a - Alert  
\b - Backspace  
\f - Form feed  
\n - New line  
\r - Carriage return  
\t - Horizontal tab  
\v - Vertical tab  
\uxxxx - Unicode escape sequence for character with hex value xxxx  
\xn[n][n][n] - Unicode escape sequence for character with hex value nnnn (variable length version of \uxxxx)  
\Uxxxxxxxx - Unicode escape sequence for character with hex value xxxxxxxx (for generating surrogates)  
https://csharpindepth.com/articles/Strings  

**¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?**  
Cuando hay un `@` antes de un `string` las secuencias de escape son tomadas de forma literal.  
```c#
  string filename1 = @"c:\documents\files\u0066.txt";
  string filename2 = "c:\\documents\\files\\u0066.txt";

  Console.WriteLine(filename1);
  Console.WriteLine(filename2);
  // The example displays the following output:
  //     c:\documents\files\u0066.txt
  //     c:\documents\files\u0066.txt
```

tpn6-RoblesJP created by GitHub Classroom
