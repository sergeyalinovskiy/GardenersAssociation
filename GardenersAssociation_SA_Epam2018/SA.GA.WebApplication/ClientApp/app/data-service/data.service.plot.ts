import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { Plot } from '../models/plot';
import { Electricity } from '../models/electricity';
import { Rate } from '../models/rate';
import { History } from '../models/history';

@Injectable()
export class DataServicePlot {
    
    private urlPlot = "/api/plot";

    constructor(private http: HttpClient) {
    }

    getPlots() {
        return this.http.get(this.urlPlot);
    }

    getPlot(id: number) {
        return this.http.get(this.urlPlot + '/' + id);
    }

    createPlot(plot: Plot) {
        return this.http.post(this.urlPlot, plot);
    }

    updatePlot(plot: Plot) {
        return this.http.put(this.urlPlot + '/' + plot.id, plot);
    }

    deletePlot(id: number) {
        return this.http.delete(this.urlPlot + '/' + id);
    }

    getUserPlots(id: number) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    }

    getPlotElectricity(id: number) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    }
}