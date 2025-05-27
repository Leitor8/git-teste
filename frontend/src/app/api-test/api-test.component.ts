import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { Post } from '../models/post';

@Component({
  selector: 'app-api-test',
  imports: [],
  templateUrl: './api-test.component.html',
  styleUrl: './api-test.component.css'
})
export class ApiTestComponent implements OnInit {

  posts: Post[] = [];

  constructor(private apiService: ApiService) { }
  
  ngOnInit(): void {
    this.apiService.getPosts().subscribe((posts: Post[]) => {
      this.posts = posts;
    });
  }

}
