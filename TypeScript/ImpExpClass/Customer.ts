export class Customer{
    constructor(private _firstName:string, private _lastname:string){}

    public get FirstName(): string{
        return this._firstName;
    }
    public get LastName(): string{
        return this._lastname;
    }
}