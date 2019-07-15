Doggo
====
A script engine for runtime inspection & modification for fast dev-test iterations.

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