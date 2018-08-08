import { Data } from "@angular/router";

export class Rate {
    constructor(
        public id?: number,
        public Name?: string,
        public Value?: number,
        public From?: Data,
        public To?: Data) { }
}