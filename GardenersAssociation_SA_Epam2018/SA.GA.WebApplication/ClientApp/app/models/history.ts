import { Data } from "@angular/router";

export class History {
    constructor(
        public id?: number,
        public UserId?: number,
        public PlotId?: number,
        public From?: Data,
        public To?: Data) { }
}