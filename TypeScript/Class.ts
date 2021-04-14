class Person
{
name : string;

constructor(message : string)
{
    this.name = message;
}

greet()
{return "Hello" + this.name;}

}

let greet = new Person("World");
console.log(greet);