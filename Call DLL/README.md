# Call DLL

編譯產生 dll 組件的指令
``` bash
$ csc /t:library acme.cs
```

主程式在編譯時需參考該 dll 組件
``` bash
$ csc /r:acme.dll example.cs
```
