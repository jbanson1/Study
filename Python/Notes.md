# Fluent Python
# Data Structures
## Chapter 1
## Magic Methods
Magic (dunder) methods are the methods behind Python's built-in operations,
named like '__methodname__'. Every operation is permanently wired to one dunder:
len(deckofcards) always calls `__len__`, deckofcards[0] always calls `__getitem__`.
Python looks at the operation and calls its fixed magic method on your object.
In the FrenchDeck example we defined a class with 2 magic methods so that when
those requests are made, the class has them available to handle it. Adding more
magic methods gives the class more capabilities — and some methods unlock several
behaviours (our `__getitem__` alone gave us indexing, slicing, loops and 'in').

##### NB: REPL (Read Evaluate Print Loop)
You type one line of Python, it runs it immediately and shows the result, then waits for your next line. A conversation with Python, rather than writing a whole file and running it.

## Emulating Numeric Types
Does what it says on the tin. Mathematical functions can be used on vectors.

```
>>> v1 = Vector(2, 4)
>>> v2 = Vector(2, 1)
>>> v1 + v2
Vector(4, 5)

>>> v = Vector(3, 4)
>>> abs(v)
5.0

>>> v * 3
Vector(9, 12)
>>> abs(v * 3)
15.0
```

## String Representation
The stars here are two dunder methods: `__repr__` and `__str__`.

`__repr__` is the developer view: unambiguous and precise, showing exactly what
the data is (a string shows its quotes: '2'), ideally as code that could
recreate the object. Used by the REPL, debuggers and logs.

`__str__` is the end-user view: a friendly display used by print(). It shows
'2' as 2 — same data, just displayed without the quotes.

If `__str__` is missing, print() falls back to `__repr__` — so if you only
implement one, implement `__repr__`.

## Bool Value of a Custom Type
When bool(x) is used on an object, Python checks in order:

1. Does the class have `__bool__`? → call it and return whatever it computes
   (our Vector's checks whether the length is zero — but that logic is ours,
   not Python's).
2. No `__bool__` but has `__len__`? → False if length is 0, True otherwise
   (this is why empty lists and strings are falsy).
3. Neither? → True. Every object is truthy by default.

## Why is len not a method
Two reasons:
1. **Speed** — for built-ins, len() reads a length field straight from the
   object's memory (no method call at all).
2. **One universal spelling** — len() is owned by Python, so "how big?" is
   spelled the same for every object ever written. Classes join in by
   implementing __len__: Python owns the call, I own the body.


   ## Chapter 1 Summary — The Python Data Model

**The big idea:** Python's syntax (len(), [], for, +, in, print) is powered by
dunder methods. Implement the right dunders and your class plugs into the
language like a native — ~10 lines of FrenchDeck behaved like a real Python
collection.

**The mechanism:** fixed wiring, not magic. Each operation calls exactly one
dunder: len(x) → `__len__`, x[0] → `__getitem__`, v1 + v2 → `__add__`. The
operation picks the method; my class decides whether it's implemented.
Python owns the call, I own the body.

**Fallback ladders (verified myself):**
1. for → `__iter__`, else `__getitem__` with 0, 1, 2... until IndexError
2. in → `__contains__`, else iterate and compare
3. print → `__str__`, else `__repr__`
4. bool → `__bool__`, else `__len__` (0 = False), else True

**Delegation:** implement dunders by handing work to built-ins that already
know how. My one-line `__getitem__` passed to a list → negative indexing,
slicing, loops and 'in' all came free. Same in `__abs__` → math.hypot.

**repr vs str:** `__repr__` = developer view, unambiguous, shows types
('2' keeps quotes), fallback for everything → implement it first.
`__str__` = friendly user view for print().

**Duck typing:** FrenchDeck strictly ticks only Sized, but behaves like a
full Collection via fallbacks. Python cares what I implement, never what I
inherit — why random.choice and sorted work on my deck.

**Why len isn't a method:** speed (field read for built-ins) + one universal
spelling owned by the language.

**Key files:** frenchdeck.py, vector_mine.py

   ## Chapter 2