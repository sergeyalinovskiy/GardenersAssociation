//import { Component, OnInit } from '@angular/core';
//import { DataService } from '../../data.service';
//import { Router, ActivatedRoute } from '@angular/router';
//import { Rate } from '../../models/rate';

//@Component({
//    templateUrl: '../rate.template/rate-list.component.html'
//})
//export class RateComponent implements OnInit {

//    id: number;
//    rate: Rate;    // изменяемый объект
//    loaded: boolean = false;

//    constructor(private dataService: DataService, private router: Router, activeRoute: ActivatedRoute) {
//        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
//    }

//    ngOnInit() {
//        if (this.id)
//            this.dataService.getRateInfo(this.id)
//                .subscribe((data: Rate) => {
//                    this.rate = data;
//                    if (this.rate != null) this.loaded = true;
//                });
//    }
//}


import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { Rate } from '../../models/rate';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    templateUrl: '../rate.template/rate-list.component.html'
})
export class RateComponent implements OnInit {

    id: number;
    rates: Rate[];
    constructor(private dataService: DataService,private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getRateInfo(this.id).subscribe((data: Rate[]) => this.rates = data);
    }
    delete(id: number) {
        this.dataService.deleteRate(id).subscribe(data => this.load());
    }
}