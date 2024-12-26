string[] myStrings = { "I like homosexuals. I like heterosexuals.", "I like all three of the menu choices" };

for (int i  = 0; i <= myStrings.Length - 1; i++) {
    
    if (myStrings[i].IndexOf('.') != 0) {
        while (myStrings[i].IndexOf('.') != -1) {
            Console.WriteLine(myStrings[i].Substring(0, myStrings[i].IndexOf('.')).TrimStart());
            myStrings[i]= myStrings[i].Remove(0, myStrings[i].IndexOf('.') + 1);
            
        }
        Console.WriteLine(myStrings[i].TrimStart());
    }

    else {
        Console.WriteLine(myStrings[i]);
    }
}

/*string a = "Hello.World";
a = a.Remove(0, a.IndexOf('.')+1);
Console.WriteLine(a);*/
