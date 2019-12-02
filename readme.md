Doggo
====
A script engine for runtime inspection & modification for fast dev-test iteration.

```
Doggo is abandoned.

SOJU also includes runtime REPL and it replaces doggo.
https://github.com/pjc0247/get_soju#repl
```
```
Doggo
* Fast (Almost zero cost to execute small codeset)
* Runs everywhere
* Unstable (Uses SlowSharp as a backend which may not compatible with advanced syntaxes)

SOJU REPL
* Slow (Requires full recompilation to execute a single line)
* Only supports Win32/Android
* Stable (Uses same backend as Unity.)
```

Feature
----
* Scripting with C# syntax.
* Zero codings for integrating doggo!
* Works with any platform.

Overview
----
Below code executes a `Jump` method from `Player` instance.<br>
`$(Player)` is a special syntax which is exactly same as `FindObjectOfType<Player>()`. We'll explain more about it later.
```cs
$(Player).Jump();
```

Sugar for doggo!
----
__Modify multiple type instances using $(TYPE)__
```cs
$(Player).Jump();
```
This actually converted into:
```cs
foreach (var c in GameObject.FindObjectsOfType<Player>())
	c.Jump();
```

__Get singleton type instance using #(TYPE)__
```cs
#(Player).Hp
```
A notable difference between `$` and `#` syntax is, `#` actually returns a value.<br>
So, if you want to retrive a property value from one specific instance, always use `#` instead of `$`.<br>
<br>
Below exmple applies damage to all `Monter` instances by `Player.Atk` value.
```cs
$(Monster).Damage( #(Player).Atk );
```
