
__D.GetMultiple<T>__
```cs
$(Player).Jump();
```
This actually converted into:
```cs
foreach (var c in D.GetMultiple<Player>())
	c.Jump();
```

__D.GetSingle<T>__
```cs
#(Player).Hp
```
```cs
$(Player).Damage( #(Player).Hp / 2 );
```