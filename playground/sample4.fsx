open System

// int means a number
type Person(first : string, last : string, age : int) =
    member p.FirstName = first
    member p.LastName = last
    member p.Age = age
    member p.SayHowdy() =
        Console.WriteLine("{0}says, 'Howdy, all'!", p.FirstName)
    override p.ToString() =
        String.Format("[Person: first:={0}, last={1}, age={2}]",
            p.FirstName, p.LastName, age)

let jess = new Person("Jessica", "Kerr", 33)
jess.SayHowdy()

type Student(first : string, last : string, age : int, subj : string) =
    inherit Person(first, last, age)
    let mutable subject = subj
    member s.Subject
        with get() = subject
        and set(value : string) = subject <- value
    override s.ToString() =
        String.Format("[Student: subject= {0} {1}]",
           s.Subject, base.ToString())
    member s.DrinkBeer(?amt : int, ?kind : string) =
        let beers = match amt with Some(beers) -> beers | None -> 12
        let brand = match kind with Some(name) -> name | None -> "Keystone"
        Console.WriteLine("{0} drank {1} {2}s!", s.FirstName, beers, brand)
let brian = new Student("Brian", "Randell", 42, "Visual Basic")
brian.DrinkBeer(6)
brian.DrinkBeer(12, "Coors")
brian.DrinkBeer()
