import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { RecipesSearchService } from 'src/app/services/recipes-search.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { FormControl, FormGroup } from '@angular/forms';
import { MatButton } from '@angular/material/button';

@Component({
  selector: 'app-recipe-template',
  templateUrl: './profile.component.html',
  styleUrls: ['scss/animate.scss', 'scss/main.scss']
})

export class ProfileComponent implements OnInit {

  public displayedColumns_recipe = ['name'];
  public id = localStorage.getItem('idUser') || '1'


  constructor(
    private router: Router,
    private recipeService: RecipesSearchService,
  ) { }

  dataSource = new MatTableDataSource<Element>(ELEMENT_DATA);

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnInit() {
    this.recipeService.GetAllRecipes().subscribe(
      (result) => {
        console.log(result);
        let i = 0;

        
        for (let j = 0; j < result.length; j++)
          if (result[j].idUser == this.id) {
            this.dataSource.data[i] = {name: ""};
            this.dataSource.data[i].name = result[j].name;
            i++;
          }
        console.log(this.dataSource.data)
        this.dataSource.data = this.dataSource.data;
      },
      (error) => {
        console.error(error);
      }
    );
  }




  public logout(): void {
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

  public save(id: string): void {
    localStorage.setItem('link_id', id);
  }

  public del(): void {
    localStorage.removeItem('idRecipe');
  }

}


export interface Element {
  name: string;
}

const ELEMENT_DATA: Element[] = [];



